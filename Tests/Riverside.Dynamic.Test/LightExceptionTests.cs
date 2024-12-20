﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

using Riverside.Scripting.Actions;
using Riverside.Scripting.Generation;
using Riverside.Scripting.Runtime;

using NUnit.Framework;

namespace Riverside.Dynamic.Test {
    [TestFixture]
    internal class LightExceptionTests {
        private Func<LightExceptionTests, IEnumerable<Expression>>[] StatementBuilders = new[] {
            new Func<LightExceptionTests, IEnumerable<Expression>>(TryCatchBuilder),
            new Func<LightExceptionTests, IEnumerable<Expression>>(TryFinallyBuilder),
            new Func<LightExceptionTests, IEnumerable<Expression>>(ThrowBuilder),
            new Func<LightExceptionTests, IEnumerable<Expression>>(CallBuilder),
            new Func<LightExceptionTests, IEnumerable<Expression>>(ReturnBuilder),
        };
        private static ParameterExpression _input = Expression.Parameter(typeof(List<string>), "log");
        private static MethodInfo _addLog = typeof(List<string>).GetMethod(nameof(List<string>.Add));
        private static LabelTarget _ret = Expression.Label(typeof(object), "return");
        private static Expression[] _catchExtras = new[] { (Expression)Expression.Default(typeof(void)), Expression.Rethrow() };

        [Test]
        public static void RunTests() {
            var param = Expression.Parameter(typeof(Exception), "foo");
            var lambdax = Expression.Lambda<Func<object>>(
                Expression.Block(
                    LightExceptions.RewriteExternal(
                        Expression.TryCatch(
                            Expression.Default(typeof(object)),
                            Expression.Catch(param, Expression.Default(typeof(object)))
                        )
                    ),
                    LightExceptions.RewriteExternal(
                        Expression.TryCatch(
                            Expression.Default(typeof(object)),
                            Expression.Catch(param, Expression.Default(typeof(object)))
                        )
                    )
                )
            );

            lambdax.Compile()();
            CompilerHelpers.LightCompile(lambdax)();

            var builder = new LightExceptionTests();
            List<string> record = new List<string>();
            List<string> rewriteRecord = new List<string>();
            int testCount = 0;
            try {
                foreach (var lambda in builder.MakeLambda()) {
                    // run each test in normal and lightweight exception modes, make sure they have the same result
                    try {

                        object res = lambda.Compile()(record);
                        if (res != null) {
                            record.Add(res.ToString());
                        }
                    } catch (Exception e) {
                        record.Add(String.Format("EXCEPTION {0}", e.GetType()));
                    }

                    try {
                        object res = ((Expression<Func<List<string>, object>>)LightExceptions.Rewrite(lambda)).Compile()(rewriteRecord);
                        Exception e = LightExceptions.GetLightException(res);
                        if (e != null) {
                            rewriteRecord.Add(String.Format("EXCEPTION {0}", e.GetType()));
                        } else if (res != null) {
                            rewriteRecord.Add(res.ToString());
                        }
                    } catch (Exception e) {
                        rewriteRecord.Add(String.Format("EXCEPTION {0}", e.GetType()));
                    }

                    if (record.Count != rewriteRecord.Count) {
                        PrintLambda(lambda, record, rewriteRecord);
                        throw new Exception("Records differ in length");
                    }
                    for (int i = 0; i < record.Count; i++) {
                        if (record[i] != rewriteRecord[i]) {
                            PrintLambda(lambda, record, rewriteRecord);
                            throw new Exception("Records differ");
                        }
                    }

                    record.Clear();
                    rewriteRecord.Clear();
                    testCount++;
                }
            } finally {
                Console.Write("Ran {0} tests", testCount);
            }
        }

        private static void PrintLambda(Expression<Func<List<string>, object>> lambda, List<string> record, List<string> rewriteRecord) {
            for (int i = 0; i < Math.Min(record.Count, rewriteRecord.Count); i++) {
                Console.WriteLine(record[i]);
                Console.WriteLine(rewriteRecord[i]);
                Console.WriteLine();
            }
        }

        private int _depth = 0;

        private IEnumerable<Expression<Func<List<string>, object>>> MakeLambda() {
            foreach (var expr in GetStatements()) {
                var res = expr;
                if (res.Type != typeof(object)) {
                    res = Expression.Block(expr, Expression.Default(typeof(object)));
                }
                yield return Expression.Lambda<Func<List<string>, object>>(
                    Expression.Label(_ret, res),
                    _input
                );
            }
        }

        private IEnumerable<Expression> GetStatements() {
            if (_depth < 2) {
                foreach (var func in StatementBuilders) {
                    foreach (var expr in func(this)) { yield return expr; }
                }
            }
        }

        private static Expression AddLogging(Expression expr, string log) {
            return Expression.Block(
                Expression.Call(
                    _input,
                    _addLog,
                    Expression.Constant(log)
                ),
                expr
            );
        }

        private static IEnumerable<Expression> ReturnBuilder(LightExceptionTests self) {
            yield return Expression.Return(_ret, Expression.Default(typeof(object)));
        }

        private static IEnumerable<Expression> TryCatchBuilder(LightExceptionTests self) {
            using (new DepthHolder(self)) {
                foreach (var body in self.GetStatements()) {
                    foreach (var handler in self.GetStatements()) {
                        for (int i = 0; i < _catchExtras.Length; i++) {
                            var extra = _catchExtras[i];

                            yield return AddLogging(
                                Expression.TryCatch(
                                    Expression.Block(typeof(void), body),
                                    Expression.Catch(
                                        typeof(Exception),
                                        AddLogging(Expression.Block(typeof(void), handler, extra), "catch " + i)
                                    )
                                ),
                                "try"
                            );

                            yield return AddLogging(
                                Expression.TryCatch(
                                    Expression.Block(typeof(void), body),
                                    Expression.Catch(
                                        typeof(InvalidOperationException),
                                        AddLogging(Expression.Block(typeof(void), handler, extra), "invalidEx catch 1 " + i)
                                    )
                                ),
                                "try"
                            );

                            yield return AddLogging(
                                Expression.TryCatch(
                                    Expression.Block(typeof(void), body),
                                    Expression.Catch(
                                        typeof(InvalidOperationException),
                                        AddLogging(Expression.Block(typeof(void), handler, extra), "invalidEx catch 2 " + i)
                                    ),
                                    Expression.Catch(
                                        typeof(InvalidOperationException),
                                        AddLogging(Expression.Block(typeof(void), handler, extra), "catch " + i)
                                    )
                                ),
                                "try"
                            );
                        }

                    }
                }
            }
        }

        private static IEnumerable<Expression> TryFinallyBuilder(LightExceptionTests self) {
            using (new DepthHolder(self)) {
                foreach (var body in self.GetStatements()) {
                    foreach (var handler in self.GetStatements()) {
                        yield return Expression.TryFinally(AddLogging(body, "try finally"), AddLogging(handler, "finally"));
                    }
                }
            }
        }

        private static IEnumerable<Expression> ThrowBuilder(LightExceptionTests self) {
            yield return AddLogging(Expression.Throw(Expression.New(typeof(Exception))), "throw ex");
            yield return AddLogging(Expression.Throw(Expression.New(typeof(InvalidOperationException))), "throw invalidEx");
        }

        private static IEnumerable<Expression> CallBuilder(LightExceptionTests self) {
            yield return AddLogging(LightExceptions.CheckAndThrow(Expression.Call(typeof(LightExceptionTests).GetMethod(nameof(LightExceptionTests.SomeCall)))), "call");
            yield return AddLogging(Expression.Call(typeof(LightExceptionTests).GetMethod(nameof(LightExceptionTests.ThrowingCall))), "call throw");
            yield return AddLogging(Expression.Call(typeof(LightExceptionTests).GetMethod(nameof(LightExceptionTests.ThrowingCallInvalidOp))), "call throw invalidop");
            yield return AddLogging(LightExceptions.CheckAndThrow(Expression.Call(typeof(LightExceptionTests).GetMethod(nameof(LightExceptionTests.LightThrowingCall)))), "call throw");
            yield return AddLogging(LightExceptions.CheckAndThrow(Expression.Call(typeof(LightExceptionTests).GetMethod(nameof(LightExceptionTests.LightThrowingCallInvalidOp)))), "call throw invalidop");
            yield return AddLogging(DynamicExpression.Dynamic(new LightExBinder("test", false), typeof(object), Expression.Constant(42)), "dynamic throw");
            yield return AddLogging(
                DynamicExpression.Dynamic(new LightExBinder("test", false), typeof(object),
                DynamicExpression.Dynamic(new LightExBinder("foo", false), typeof(object), Expression.Constant(42))), "dynamic nothrow");
        }

        public static object SomeCall() {
            return null;
        }

        public static object ThrowingCall() {
            throw new Exception();
        }

        public static object ThrowingCallInvalidOp() {
            throw new InvalidOperationException();
        }

        public static object LightThrowingCall() {
            return LightExceptions.Throw(new Exception());
        }

        public static object LightThrowingCallInvalidOp() {
            return LightExceptions.Throw(new InvalidOperationException());
        }

        private struct DepthHolder : IDisposable {
            private LightExceptionTests Builder;
            public DepthHolder(LightExceptionTests builder) {
                Builder = builder;
                builder._depth++;
            }

            public void Dispose() {
                Builder._depth--;
            }
        }

        private class LightExBinder : GetMemberBinder, ILightExceptionBinder {
            private bool _supportsLightEx;
            public LightExBinder(string name, bool supportsLightEx)
                : base(name, false) {
                _supportsLightEx = supportsLightEx;
            }

            public override DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion) {
                var ex = Expression.New(typeof(MissingMemberException));
                Expression body;
                if (Name == "foo") {
                    body = target.Expression;
                } else if (_supportsLightEx) {
                    body = LightExceptions.Throw(ex, typeof(object));
                } else {
                    body = Expression.Throw(ex, typeof(object));
                }

                return new DynamicMetaObject(
                    body,
                    BindingRestrictions.GetTypeRestriction(target.Expression, target.Value.GetType())
                );
            }

            #region ILightExceptionBinder Members

            public bool SupportsLightThrow {
                get { return _supportsLightEx; }
            }

            public CallSiteBinder GetLightExceptionBinder() {
                return new LightExBinder(Name, true);
            }

            #endregion
        }

        [Test]
        public static void IronPython2_Gh563() {
            LightExceptions.Rewrite(Expression.Constant(3.14, typeof(double))).Reduce();
        }
    }
}
