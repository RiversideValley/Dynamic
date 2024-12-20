// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

using Riverside.Scripting.Utils;

namespace Riverside.Scripting.Runtime {

    // TODO: this class should be abstract
    public class ScopeExtension {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2105:ArrayFieldsShouldNotBeReadOnly")]
        public static readonly ScopeExtension[] EmptyArray = System.Array.Empty<ScopeExtension>();

        public Scope Scope { get; }

        public ScopeExtension(Scope scope) {
            ContractUtils.RequiresNotNull(scope, nameof(scope));
            Scope = scope;
        }
    }
}
