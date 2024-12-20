// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.


using System;
using System.Runtime.CompilerServices;
using System.Reflection;
using Riverside.Scripting.Utils;

namespace Riverside.Scripting.Interpreter {
    public partial class LightLambda {
        #region Generated LightLambda Run Methods

        // *** BEGIN GENERATED CODE ***
        // generated by function: gen_run_methods from: generate_dynamic_instructions.py

        internal const int MaxParameters = 16;
        internal TRet Run0<TRet>() {
            if (_compiled != null || TryGetCompiled()) {
                return ((Func<TRet>)_compiled)();
            }

            var frame = MakeFrame();
            var current = frame.Enter();
            try { _interpreter.Run(frame); } finally { frame.Leave(current); }
            return (TRet)frame.Pop();
        }

        internal void RunVoid0() {
            if (_compiled != null || TryGetCompiled()) {
                ((Action)_compiled)();
                return;
            }

            var frame = MakeFrame();
            var current = frame.Enter();
            try { _interpreter.Run(frame); } finally { frame.Leave(current); }
        }

        internal static Delegate MakeRun0<TRet>(LightLambda lambda) {
            return new Func<TRet>(lambda.Run0<TRet>);
        }
        internal static Delegate MakeRunVoid0(LightLambda lambda) {
            return new Action(lambda.RunVoid0);
        }
        internal TRet Run1<T0,TRet>(T0 arg0) {
            if (_compiled != null || TryGetCompiled()) {
                return ((Func<T0,TRet>)_compiled)(arg0);
            }

            var frame = MakeFrame();
            frame.Data[0] = arg0;
            var current = frame.Enter();
            try { _interpreter.Run(frame); } finally { frame.Leave(current); }
            return (TRet)frame.Pop();
        }

        internal void RunVoid1<T0>(T0 arg0) {
            if (_compiled != null || TryGetCompiled()) {
                ((Action<T0>)_compiled)(arg0);
                return;
            }

            var frame = MakeFrame();
            frame.Data[0] = arg0;
            var current = frame.Enter();
            try { _interpreter.Run(frame); } finally { frame.Leave(current); }
        }

        internal static Delegate MakeRun1<T0,TRet>(LightLambda lambda) {
            return new Func<T0,TRet>(lambda.Run1<T0,TRet>);
        }
        internal static Delegate MakeRunVoid1<T0>(LightLambda lambda) {
            return new Action<T0>(lambda.RunVoid1<T0>);
        }
        internal TRet Run2<T0,T1,TRet>(T0 arg0,T1 arg1) {
            if (_compiled != null || TryGetCompiled()) {
                return ((Func<T0,T1,TRet>)_compiled)(arg0, arg1);
            }

            var frame = MakeFrame();
            frame.Data[0] = arg0;
            frame.Data[1] = arg1;
            var current = frame.Enter();
            try { _interpreter.Run(frame); } finally { frame.Leave(current); }
            return (TRet)frame.Pop();
        }

        internal void RunVoid2<T0,T1>(T0 arg0,T1 arg1) {
            if (_compiled != null || TryGetCompiled()) {
                ((Action<T0,T1>)_compiled)(arg0, arg1);
                return;
            }

            var frame = MakeFrame();
            frame.Data[0] = arg0;
            frame.Data[1] = arg1;
            var current = frame.Enter();
            try { _interpreter.Run(frame); } finally { frame.Leave(current); }
        }

        internal static Delegate MakeRun2<T0,T1,TRet>(LightLambda lambda) {
            return new Func<T0,T1,TRet>(lambda.Run2<T0,T1,TRet>);
        }
        internal static Delegate MakeRunVoid2<T0,T1>(LightLambda lambda) {
            return new Action<T0,T1>(lambda.RunVoid2<T0,T1>);
        }
        internal TRet Run3<T0,T1,T2,TRet>(T0 arg0,T1 arg1,T2 arg2) {
            if (_compiled != null || TryGetCompiled()) {
                return ((Func<T0,T1,T2,TRet>)_compiled)(arg0, arg1, arg2);
            }

            var frame = MakeFrame();
            frame.Data[0] = arg0;
            frame.Data[1] = arg1;
            frame.Data[2] = arg2;
            var current = frame.Enter();
            try { _interpreter.Run(frame); } finally { frame.Leave(current); }
            return (TRet)frame.Pop();
        }

        internal void RunVoid3<T0,T1,T2>(T0 arg0,T1 arg1,T2 arg2) {
            if (_compiled != null || TryGetCompiled()) {
                ((Action<T0,T1,T2>)_compiled)(arg0, arg1, arg2);
                return;
            }

            var frame = MakeFrame();
            frame.Data[0] = arg0;
            frame.Data[1] = arg1;
            frame.Data[2] = arg2;
            var current = frame.Enter();
            try { _interpreter.Run(frame); } finally { frame.Leave(current); }
        }

        internal static Delegate MakeRun3<T0,T1,T2,TRet>(LightLambda lambda) {
            return new Func<T0,T1,T2,TRet>(lambda.Run3<T0,T1,T2,TRet>);
        }
        internal static Delegate MakeRunVoid3<T0,T1,T2>(LightLambda lambda) {
            return new Action<T0,T1,T2>(lambda.RunVoid3<T0,T1,T2>);
        }
        internal TRet Run4<T0,T1,T2,T3,TRet>(T0 arg0,T1 arg1,T2 arg2,T3 arg3) {
            if (_compiled != null || TryGetCompiled()) {
                return ((Func<T0,T1,T2,T3,TRet>)_compiled)(arg0, arg1, arg2, arg3);
            }

            var frame = MakeFrame();
            frame.Data[0] = arg0;
            frame.Data[1] = arg1;
            frame.Data[2] = arg2;
            frame.Data[3] = arg3;
            var current = frame.Enter();
            try { _interpreter.Run(frame); } finally { frame.Leave(current); }
            return (TRet)frame.Pop();
        }

        internal void RunVoid4<T0,T1,T2,T3>(T0 arg0,T1 arg1,T2 arg2,T3 arg3) {
            if (_compiled != null || TryGetCompiled()) {
                ((Action<T0,T1,T2,T3>)_compiled)(arg0, arg1, arg2, arg3);
                return;
            }

            var frame = MakeFrame();
            frame.Data[0] = arg0;
            frame.Data[1] = arg1;
            frame.Data[2] = arg2;
            frame.Data[3] = arg3;
            var current = frame.Enter();
            try { _interpreter.Run(frame); } finally { frame.Leave(current); }
        }

        internal static Delegate MakeRun4<T0,T1,T2,T3,TRet>(LightLambda lambda) {
            return new Func<T0,T1,T2,T3,TRet>(lambda.Run4<T0,T1,T2,T3,TRet>);
        }
        internal static Delegate MakeRunVoid4<T0,T1,T2,T3>(LightLambda lambda) {
            return new Action<T0,T1,T2,T3>(lambda.RunVoid4<T0,T1,T2,T3>);
        }
        internal TRet Run5<T0,T1,T2,T3,T4,TRet>(T0 arg0,T1 arg1,T2 arg2,T3 arg3,T4 arg4) {
            if (_compiled != null || TryGetCompiled()) {
                return ((Func<T0,T1,T2,T3,T4,TRet>)_compiled)(arg0, arg1, arg2, arg3, arg4);
            }

            var frame = MakeFrame();
            frame.Data[0] = arg0;
            frame.Data[1] = arg1;
            frame.Data[2] = arg2;
            frame.Data[3] = arg3;
            frame.Data[4] = arg4;
            var current = frame.Enter();
            try { _interpreter.Run(frame); } finally { frame.Leave(current); }
            return (TRet)frame.Pop();
        }

        internal void RunVoid5<T0,T1,T2,T3,T4>(T0 arg0,T1 arg1,T2 arg2,T3 arg3,T4 arg4) {
            if (_compiled != null || TryGetCompiled()) {
                ((Action<T0,T1,T2,T3,T4>)_compiled)(arg0, arg1, arg2, arg3, arg4);
                return;
            }

            var frame = MakeFrame();
            frame.Data[0] = arg0;
            frame.Data[1] = arg1;
            frame.Data[2] = arg2;
            frame.Data[3] = arg3;
            frame.Data[4] = arg4;
            var current = frame.Enter();
            try { _interpreter.Run(frame); } finally { frame.Leave(current); }
        }

        internal static Delegate MakeRun5<T0,T1,T2,T3,T4,TRet>(LightLambda lambda) {
            return new Func<T0,T1,T2,T3,T4,TRet>(lambda.Run5<T0,T1,T2,T3,T4,TRet>);
        }
        internal static Delegate MakeRunVoid5<T0,T1,T2,T3,T4>(LightLambda lambda) {
            return new Action<T0,T1,T2,T3,T4>(lambda.RunVoid5<T0,T1,T2,T3,T4>);
        }
        internal TRet Run6<T0,T1,T2,T3,T4,T5,TRet>(T0 arg0,T1 arg1,T2 arg2,T3 arg3,T4 arg4,T5 arg5) {
            if (_compiled != null || TryGetCompiled()) {
                return ((Func<T0,T1,T2,T3,T4,T5,TRet>)_compiled)(arg0, arg1, arg2, arg3, arg4, arg5);
            }

            var frame = MakeFrame();
            frame.Data[0] = arg0;
            frame.Data[1] = arg1;
            frame.Data[2] = arg2;
            frame.Data[3] = arg3;
            frame.Data[4] = arg4;
            frame.Data[5] = arg5;
            var current = frame.Enter();
            try { _interpreter.Run(frame); } finally { frame.Leave(current); }
            return (TRet)frame.Pop();
        }

        internal void RunVoid6<T0,T1,T2,T3,T4,T5>(T0 arg0,T1 arg1,T2 arg2,T3 arg3,T4 arg4,T5 arg5) {
            if (_compiled != null || TryGetCompiled()) {
                ((Action<T0,T1,T2,T3,T4,T5>)_compiled)(arg0, arg1, arg2, arg3, arg4, arg5);
                return;
            }

            var frame = MakeFrame();
            frame.Data[0] = arg0;
            frame.Data[1] = arg1;
            frame.Data[2] = arg2;
            frame.Data[3] = arg3;
            frame.Data[4] = arg4;
            frame.Data[5] = arg5;
            var current = frame.Enter();
            try { _interpreter.Run(frame); } finally { frame.Leave(current); }
        }

        internal static Delegate MakeRun6<T0,T1,T2,T3,T4,T5,TRet>(LightLambda lambda) {
            return new Func<T0,T1,T2,T3,T4,T5,TRet>(lambda.Run6<T0,T1,T2,T3,T4,T5,TRet>);
        }
        internal static Delegate MakeRunVoid6<T0,T1,T2,T3,T4,T5>(LightLambda lambda) {
            return new Action<T0,T1,T2,T3,T4,T5>(lambda.RunVoid6<T0,T1,T2,T3,T4,T5>);
        }
        internal TRet Run7<T0,T1,T2,T3,T4,T5,T6,TRet>(T0 arg0,T1 arg1,T2 arg2,T3 arg3,T4 arg4,T5 arg5,T6 arg6) {
            if (_compiled != null || TryGetCompiled()) {
                return ((Func<T0,T1,T2,T3,T4,T5,T6,TRet>)_compiled)(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
            }

            var frame = MakeFrame();
            frame.Data[0] = arg0;
            frame.Data[1] = arg1;
            frame.Data[2] = arg2;
            frame.Data[3] = arg3;
            frame.Data[4] = arg4;
            frame.Data[5] = arg5;
            frame.Data[6] = arg6;
            var current = frame.Enter();
            try { _interpreter.Run(frame); } finally { frame.Leave(current); }
            return (TRet)frame.Pop();
        }

        internal void RunVoid7<T0,T1,T2,T3,T4,T5,T6>(T0 arg0,T1 arg1,T2 arg2,T3 arg3,T4 arg4,T5 arg5,T6 arg6) {
            if (_compiled != null || TryGetCompiled()) {
                ((Action<T0,T1,T2,T3,T4,T5,T6>)_compiled)(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
                return;
            }

            var frame = MakeFrame();
            frame.Data[0] = arg0;
            frame.Data[1] = arg1;
            frame.Data[2] = arg2;
            frame.Data[3] = arg3;
            frame.Data[4] = arg4;
            frame.Data[5] = arg5;
            frame.Data[6] = arg6;
            var current = frame.Enter();
            try { _interpreter.Run(frame); } finally { frame.Leave(current); }
        }

        internal static Delegate MakeRun7<T0,T1,T2,T3,T4,T5,T6,TRet>(LightLambda lambda) {
            return new Func<T0,T1,T2,T3,T4,T5,T6,TRet>(lambda.Run7<T0,T1,T2,T3,T4,T5,T6,TRet>);
        }
        internal static Delegate MakeRunVoid7<T0,T1,T2,T3,T4,T5,T6>(LightLambda lambda) {
            return new Action<T0,T1,T2,T3,T4,T5,T6>(lambda.RunVoid7<T0,T1,T2,T3,T4,T5,T6>);
        }
        internal TRet Run8<T0,T1,T2,T3,T4,T5,T6,T7,TRet>(T0 arg0,T1 arg1,T2 arg2,T3 arg3,T4 arg4,T5 arg5,T6 arg6,T7 arg7) {
            if (_compiled != null || TryGetCompiled()) {
                return ((Func<T0,T1,T2,T3,T4,T5,T6,T7,TRet>)_compiled)(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
            }

            var frame = MakeFrame();
            frame.Data[0] = arg0;
            frame.Data[1] = arg1;
            frame.Data[2] = arg2;
            frame.Data[3] = arg3;
            frame.Data[4] = arg4;
            frame.Data[5] = arg5;
            frame.Data[6] = arg6;
            frame.Data[7] = arg7;
            var current = frame.Enter();
            try { _interpreter.Run(frame); } finally { frame.Leave(current); }
            return (TRet)frame.Pop();
        }

        internal void RunVoid8<T0,T1,T2,T3,T4,T5,T6,T7>(T0 arg0,T1 arg1,T2 arg2,T3 arg3,T4 arg4,T5 arg5,T6 arg6,T7 arg7) {
            if (_compiled != null || TryGetCompiled()) {
                ((Action<T0,T1,T2,T3,T4,T5,T6,T7>)_compiled)(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
                return;
            }

            var frame = MakeFrame();
            frame.Data[0] = arg0;
            frame.Data[1] = arg1;
            frame.Data[2] = arg2;
            frame.Data[3] = arg3;
            frame.Data[4] = arg4;
            frame.Data[5] = arg5;
            frame.Data[6] = arg6;
            frame.Data[7] = arg7;
            var current = frame.Enter();
            try { _interpreter.Run(frame); } finally { frame.Leave(current); }
        }

        internal static Delegate MakeRun8<T0,T1,T2,T3,T4,T5,T6,T7,TRet>(LightLambda lambda) {
            return new Func<T0,T1,T2,T3,T4,T5,T6,T7,TRet>(lambda.Run8<T0,T1,T2,T3,T4,T5,T6,T7,TRet>);
        }
        internal static Delegate MakeRunVoid8<T0,T1,T2,T3,T4,T5,T6,T7>(LightLambda lambda) {
            return new Action<T0,T1,T2,T3,T4,T5,T6,T7>(lambda.RunVoid8<T0,T1,T2,T3,T4,T5,T6,T7>);
        }
        internal TRet Run9<T0,T1,T2,T3,T4,T5,T6,T7,T8,TRet>(T0 arg0,T1 arg1,T2 arg2,T3 arg3,T4 arg4,T5 arg5,T6 arg6,T7 arg7,T8 arg8) {
            if (_compiled != null || TryGetCompiled()) {
                return ((Func<T0,T1,T2,T3,T4,T5,T6,T7,T8,TRet>)_compiled)(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
            }

            var frame = MakeFrame();
            frame.Data[0] = arg0;
            frame.Data[1] = arg1;
            frame.Data[2] = arg2;
            frame.Data[3] = arg3;
            frame.Data[4] = arg4;
            frame.Data[5] = arg5;
            frame.Data[6] = arg6;
            frame.Data[7] = arg7;
            frame.Data[8] = arg8;
            var current = frame.Enter();
            try { _interpreter.Run(frame); } finally { frame.Leave(current); }
            return (TRet)frame.Pop();
        }

        internal void RunVoid9<T0,T1,T2,T3,T4,T5,T6,T7,T8>(T0 arg0,T1 arg1,T2 arg2,T3 arg3,T4 arg4,T5 arg5,T6 arg6,T7 arg7,T8 arg8) {
            if (_compiled != null || TryGetCompiled()) {
                ((Action<T0,T1,T2,T3,T4,T5,T6,T7,T8>)_compiled)(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
                return;
            }

            var frame = MakeFrame();
            frame.Data[0] = arg0;
            frame.Data[1] = arg1;
            frame.Data[2] = arg2;
            frame.Data[3] = arg3;
            frame.Data[4] = arg4;
            frame.Data[5] = arg5;
            frame.Data[6] = arg6;
            frame.Data[7] = arg7;
            frame.Data[8] = arg8;
            var current = frame.Enter();
            try { _interpreter.Run(frame); } finally { frame.Leave(current); }
        }

        internal static Delegate MakeRun9<T0,T1,T2,T3,T4,T5,T6,T7,T8,TRet>(LightLambda lambda) {
            return new Func<T0,T1,T2,T3,T4,T5,T6,T7,T8,TRet>(lambda.Run9<T0,T1,T2,T3,T4,T5,T6,T7,T8,TRet>);
        }
        internal static Delegate MakeRunVoid9<T0,T1,T2,T3,T4,T5,T6,T7,T8>(LightLambda lambda) {
            return new Action<T0,T1,T2,T3,T4,T5,T6,T7,T8>(lambda.RunVoid9<T0,T1,T2,T3,T4,T5,T6,T7,T8>);
        }
        internal TRet Run10<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,TRet>(T0 arg0,T1 arg1,T2 arg2,T3 arg3,T4 arg4,T5 arg5,T6 arg6,T7 arg7,T8 arg8,T9 arg9) {
            if (_compiled != null || TryGetCompiled()) {
                return ((Func<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,TRet>)_compiled)(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
            }

            var frame = MakeFrame();
            frame.Data[0] = arg0;
            frame.Data[1] = arg1;
            frame.Data[2] = arg2;
            frame.Data[3] = arg3;
            frame.Data[4] = arg4;
            frame.Data[5] = arg5;
            frame.Data[6] = arg6;
            frame.Data[7] = arg7;
            frame.Data[8] = arg8;
            frame.Data[9] = arg9;
            var current = frame.Enter();
            try { _interpreter.Run(frame); } finally { frame.Leave(current); }
            return (TRet)frame.Pop();
        }

        internal void RunVoid10<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>(T0 arg0,T1 arg1,T2 arg2,T3 arg3,T4 arg4,T5 arg5,T6 arg6,T7 arg7,T8 arg8,T9 arg9) {
            if (_compiled != null || TryGetCompiled()) {
                ((Action<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>)_compiled)(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
                return;
            }

            var frame = MakeFrame();
            frame.Data[0] = arg0;
            frame.Data[1] = arg1;
            frame.Data[2] = arg2;
            frame.Data[3] = arg3;
            frame.Data[4] = arg4;
            frame.Data[5] = arg5;
            frame.Data[6] = arg6;
            frame.Data[7] = arg7;
            frame.Data[8] = arg8;
            frame.Data[9] = arg9;
            var current = frame.Enter();
            try { _interpreter.Run(frame); } finally { frame.Leave(current); }
        }

        internal static Delegate MakeRun10<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,TRet>(LightLambda lambda) {
            return new Func<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,TRet>(lambda.Run10<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,TRet>);
        }
        internal static Delegate MakeRunVoid10<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>(LightLambda lambda) {
            return new Action<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>(lambda.RunVoid10<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>);
        }
        internal TRet Run11<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,TRet>(T0 arg0,T1 arg1,T2 arg2,T3 arg3,T4 arg4,T5 arg5,T6 arg6,T7 arg7,T8 arg8,T9 arg9,T10 arg10) {
            if (_compiled != null || TryGetCompiled()) {
                return ((Func<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,TRet>)_compiled)(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
            }

            var frame = MakeFrame();
            frame.Data[0] = arg0;
            frame.Data[1] = arg1;
            frame.Data[2] = arg2;
            frame.Data[3] = arg3;
            frame.Data[4] = arg4;
            frame.Data[5] = arg5;
            frame.Data[6] = arg6;
            frame.Data[7] = arg7;
            frame.Data[8] = arg8;
            frame.Data[9] = arg9;
            frame.Data[10] = arg10;
            var current = frame.Enter();
            try { _interpreter.Run(frame); } finally { frame.Leave(current); }
            return (TRet)frame.Pop();
        }

        internal void RunVoid11<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(T0 arg0,T1 arg1,T2 arg2,T3 arg3,T4 arg4,T5 arg5,T6 arg6,T7 arg7,T8 arg8,T9 arg9,T10 arg10) {
            if (_compiled != null || TryGetCompiled()) {
                ((Action<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>)_compiled)(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
                return;
            }

            var frame = MakeFrame();
            frame.Data[0] = arg0;
            frame.Data[1] = arg1;
            frame.Data[2] = arg2;
            frame.Data[3] = arg3;
            frame.Data[4] = arg4;
            frame.Data[5] = arg5;
            frame.Data[6] = arg6;
            frame.Data[7] = arg7;
            frame.Data[8] = arg8;
            frame.Data[9] = arg9;
            frame.Data[10] = arg10;
            var current = frame.Enter();
            try { _interpreter.Run(frame); } finally { frame.Leave(current); }
        }

        internal static Delegate MakeRun11<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,TRet>(LightLambda lambda) {
            return new Func<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,TRet>(lambda.Run11<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,TRet>);
        }
        internal static Delegate MakeRunVoid11<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(LightLambda lambda) {
            return new Action<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(lambda.RunVoid11<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>);
        }
        internal TRet Run12<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,TRet>(T0 arg0,T1 arg1,T2 arg2,T3 arg3,T4 arg4,T5 arg5,T6 arg6,T7 arg7,T8 arg8,T9 arg9,T10 arg10,T11 arg11) {
            if (_compiled != null || TryGetCompiled()) {
                return ((Func<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,TRet>)_compiled)(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
            }

            var frame = MakeFrame();
            frame.Data[0] = arg0;
            frame.Data[1] = arg1;
            frame.Data[2] = arg2;
            frame.Data[3] = arg3;
            frame.Data[4] = arg4;
            frame.Data[5] = arg5;
            frame.Data[6] = arg6;
            frame.Data[7] = arg7;
            frame.Data[8] = arg8;
            frame.Data[9] = arg9;
            frame.Data[10] = arg10;
            frame.Data[11] = arg11;
            var current = frame.Enter();
            try { _interpreter.Run(frame); } finally { frame.Leave(current); }
            return (TRet)frame.Pop();
        }

        internal void RunVoid12<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(T0 arg0,T1 arg1,T2 arg2,T3 arg3,T4 arg4,T5 arg5,T6 arg6,T7 arg7,T8 arg8,T9 arg9,T10 arg10,T11 arg11) {
            if (_compiled != null || TryGetCompiled()) {
                ((Action<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>)_compiled)(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
                return;
            }

            var frame = MakeFrame();
            frame.Data[0] = arg0;
            frame.Data[1] = arg1;
            frame.Data[2] = arg2;
            frame.Data[3] = arg3;
            frame.Data[4] = arg4;
            frame.Data[5] = arg5;
            frame.Data[6] = arg6;
            frame.Data[7] = arg7;
            frame.Data[8] = arg8;
            frame.Data[9] = arg9;
            frame.Data[10] = arg10;
            frame.Data[11] = arg11;
            var current = frame.Enter();
            try { _interpreter.Run(frame); } finally { frame.Leave(current); }
        }

        internal static Delegate MakeRun12<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,TRet>(LightLambda lambda) {
            return new Func<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,TRet>(lambda.Run12<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,TRet>);
        }
        internal static Delegate MakeRunVoid12<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(LightLambda lambda) {
            return new Action<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(lambda.RunVoid12<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>);
        }
        internal TRet Run13<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,TRet>(T0 arg0,T1 arg1,T2 arg2,T3 arg3,T4 arg4,T5 arg5,T6 arg6,T7 arg7,T8 arg8,T9 arg9,T10 arg10,T11 arg11,T12 arg12) {
            if (_compiled != null || TryGetCompiled()) {
                return ((Func<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,TRet>)_compiled)(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
            }

            var frame = MakeFrame();
            frame.Data[0] = arg0;
            frame.Data[1] = arg1;
            frame.Data[2] = arg2;
            frame.Data[3] = arg3;
            frame.Data[4] = arg4;
            frame.Data[5] = arg5;
            frame.Data[6] = arg6;
            frame.Data[7] = arg7;
            frame.Data[8] = arg8;
            frame.Data[9] = arg9;
            frame.Data[10] = arg10;
            frame.Data[11] = arg11;
            frame.Data[12] = arg12;
            var current = frame.Enter();
            try { _interpreter.Run(frame); } finally { frame.Leave(current); }
            return (TRet)frame.Pop();
        }

        internal void RunVoid13<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(T0 arg0,T1 arg1,T2 arg2,T3 arg3,T4 arg4,T5 arg5,T6 arg6,T7 arg7,T8 arg8,T9 arg9,T10 arg10,T11 arg11,T12 arg12) {
            if (_compiled != null || TryGetCompiled()) {
                ((Action<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>)_compiled)(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
                return;
            }

            var frame = MakeFrame();
            frame.Data[0] = arg0;
            frame.Data[1] = arg1;
            frame.Data[2] = arg2;
            frame.Data[3] = arg3;
            frame.Data[4] = arg4;
            frame.Data[5] = arg5;
            frame.Data[6] = arg6;
            frame.Data[7] = arg7;
            frame.Data[8] = arg8;
            frame.Data[9] = arg9;
            frame.Data[10] = arg10;
            frame.Data[11] = arg11;
            frame.Data[12] = arg12;
            var current = frame.Enter();
            try { _interpreter.Run(frame); } finally { frame.Leave(current); }
        }

        internal static Delegate MakeRun13<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,TRet>(LightLambda lambda) {
            return new Func<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,TRet>(lambda.Run13<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,TRet>);
        }
        internal static Delegate MakeRunVoid13<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(LightLambda lambda) {
            return new Action<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(lambda.RunVoid13<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>);
        }
        internal TRet Run14<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,TRet>(T0 arg0,T1 arg1,T2 arg2,T3 arg3,T4 arg4,T5 arg5,T6 arg6,T7 arg7,T8 arg8,T9 arg9,T10 arg10,T11 arg11,T12 arg12,T13 arg13) {
            if (_compiled != null || TryGetCompiled()) {
                return ((Func<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,TRet>)_compiled)(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
            }

            var frame = MakeFrame();
            frame.Data[0] = arg0;
            frame.Data[1] = arg1;
            frame.Data[2] = arg2;
            frame.Data[3] = arg3;
            frame.Data[4] = arg4;
            frame.Data[5] = arg5;
            frame.Data[6] = arg6;
            frame.Data[7] = arg7;
            frame.Data[8] = arg8;
            frame.Data[9] = arg9;
            frame.Data[10] = arg10;
            frame.Data[11] = arg11;
            frame.Data[12] = arg12;
            frame.Data[13] = arg13;
            var current = frame.Enter();
            try { _interpreter.Run(frame); } finally { frame.Leave(current); }
            return (TRet)frame.Pop();
        }

        internal void RunVoid14<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(T0 arg0,T1 arg1,T2 arg2,T3 arg3,T4 arg4,T5 arg5,T6 arg6,T7 arg7,T8 arg8,T9 arg9,T10 arg10,T11 arg11,T12 arg12,T13 arg13) {
            if (_compiled != null || TryGetCompiled()) {
                ((Action<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>)_compiled)(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
                return;
            }

            var frame = MakeFrame();
            frame.Data[0] = arg0;
            frame.Data[1] = arg1;
            frame.Data[2] = arg2;
            frame.Data[3] = arg3;
            frame.Data[4] = arg4;
            frame.Data[5] = arg5;
            frame.Data[6] = arg6;
            frame.Data[7] = arg7;
            frame.Data[8] = arg8;
            frame.Data[9] = arg9;
            frame.Data[10] = arg10;
            frame.Data[11] = arg11;
            frame.Data[12] = arg12;
            frame.Data[13] = arg13;
            var current = frame.Enter();
            try { _interpreter.Run(frame); } finally { frame.Leave(current); }
        }

        internal static Delegate MakeRun14<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,TRet>(LightLambda lambda) {
            return new Func<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,TRet>(lambda.Run14<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,TRet>);
        }
        internal static Delegate MakeRunVoid14<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(LightLambda lambda) {
            return new Action<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(lambda.RunVoid14<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>);
        }
        internal TRet Run15<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,TRet>(T0 arg0,T1 arg1,T2 arg2,T3 arg3,T4 arg4,T5 arg5,T6 arg6,T7 arg7,T8 arg8,T9 arg9,T10 arg10,T11 arg11,T12 arg12,T13 arg13,T14 arg14) {
            if (_compiled != null || TryGetCompiled()) {
                return ((Func<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,TRet>)_compiled)(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
            }

            var frame = MakeFrame();
            frame.Data[0] = arg0;
            frame.Data[1] = arg1;
            frame.Data[2] = arg2;
            frame.Data[3] = arg3;
            frame.Data[4] = arg4;
            frame.Data[5] = arg5;
            frame.Data[6] = arg6;
            frame.Data[7] = arg7;
            frame.Data[8] = arg8;
            frame.Data[9] = arg9;
            frame.Data[10] = arg10;
            frame.Data[11] = arg11;
            frame.Data[12] = arg12;
            frame.Data[13] = arg13;
            frame.Data[14] = arg14;
            var current = frame.Enter();
            try { _interpreter.Run(frame); } finally { frame.Leave(current); }
            return (TRet)frame.Pop();
        }

        internal void RunVoid15<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(T0 arg0,T1 arg1,T2 arg2,T3 arg3,T4 arg4,T5 arg5,T6 arg6,T7 arg7,T8 arg8,T9 arg9,T10 arg10,T11 arg11,T12 arg12,T13 arg13,T14 arg14) {
            if (_compiled != null || TryGetCompiled()) {
                ((Action<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>)_compiled)(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
                return;
            }

            var frame = MakeFrame();
            frame.Data[0] = arg0;
            frame.Data[1] = arg1;
            frame.Data[2] = arg2;
            frame.Data[3] = arg3;
            frame.Data[4] = arg4;
            frame.Data[5] = arg5;
            frame.Data[6] = arg6;
            frame.Data[7] = arg7;
            frame.Data[8] = arg8;
            frame.Data[9] = arg9;
            frame.Data[10] = arg10;
            frame.Data[11] = arg11;
            frame.Data[12] = arg12;
            frame.Data[13] = arg13;
            frame.Data[14] = arg14;
            var current = frame.Enter();
            try { _interpreter.Run(frame); } finally { frame.Leave(current); }
        }

        internal static Delegate MakeRun15<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,TRet>(LightLambda lambda) {
            return new Func<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,TRet>(lambda.Run15<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,TRet>);
        }
        internal static Delegate MakeRunVoid15<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(LightLambda lambda) {
            return new Action<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(lambda.RunVoid15<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>);
        }

        // *** END GENERATED CODE ***

        #endregion

    }
}
