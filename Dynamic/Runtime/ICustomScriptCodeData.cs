// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

namespace Riverside.Scripting {
    /// <summary>
    /// Gets custom data to be serialized when saving script codes to disk.
    /// </summary>
    public interface ICustomScriptCodeData {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
        string GetCustomScriptCodeData();
    }
}
