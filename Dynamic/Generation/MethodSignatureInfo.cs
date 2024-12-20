// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

using System.Reflection;

namespace Riverside.Scripting.Generation {
    /// <summary>
    /// Helper class to remove methods w/ identical signatures.  Used for GetDefaultMembers
    /// which returns members from all types in the hierarchy.
    /// </summary>
    public class MethodSignatureInfo {
        private readonly ParameterInfo[] _pis;
        private readonly bool _isStatic;
        private readonly int _genericArity;

        public MethodSignatureInfo(MethodInfo info)
            : this(info.IsStatic, info.GetParameters(), info.IsGenericMethodDefinition ? info.GetGenericArguments().Length : 0){
        }

        public MethodSignatureInfo(bool isStatic, ParameterInfo[] pis, int genericArity) {
            _isStatic = isStatic;
            _pis = pis;
            _genericArity = genericArity;
        }

        public override bool Equals(object obj) {
            MethodSignatureInfo args = obj as MethodSignatureInfo;
            if (args == null) return false;
            if (args._isStatic != _isStatic || args._pis.Length != _pis.Length || args._genericArity != _genericArity) {
                return false;
            }

            for (int i = 0; i < _pis.Length; i++) {
                ParameterInfo self = _pis[i];
                ParameterInfo other = args._pis[i];

                if (self.ParameterType != other.ParameterType)
                    return false;
            }

            return true;
        }

        public override int GetHashCode() {
            int hash = 6551 ^ (_isStatic ? 79234 : 3123) ^ _genericArity;
            foreach (ParameterInfo pi in _pis) {
                hash ^= pi.ParameterType.GetHashCode();
            }
            return hash;
        }
    }
}
