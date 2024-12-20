// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

using System;

namespace Riverside.Scripting.Actions {
    [Flags]
    public enum TrackerTypes {
        None = 0x00,
        /// <summary> Specifies that the member is a constructor, representing a ConstructorTracker </summary>
        Constructor = 0x01,
        /// <summary> Specifies that the member is an event, representing a EventTracker </summary>
        Event = 0x02,
        /// <summary> Specifies that the member is a field, representing a FieldTracker </summary>
        Field = 0x04,
        /// <summary> Specifies that the member is a method, representing a MethodTracker </summary>
        Method = 0x08,
        /// <summary> Specifies that the member is a property, representing a PropertyTracker </summary>
        Property = 0x10,
        /// <summary> Specifies that the member is a property, representing a TypeTracker </summary>
        Type = 0x20,
        /// <summary> Specifies that the member is a namespace, representing a NamespaceTracker </summary>
        Namespace = 0x40,
        /// <summary> Specifies that the member is a group of method overloads, representing a MethodGroup</summary>
        MethodGroup = 0x80,
        /// <summary> Specifies that the member is a group of types that very by arity, representing a TypeGroup</summary>
        TypeGroup = 0x100,
        /// <summary> Specifies that the member is a custom meber, represetning a CustomTracker </summary>
        Custom = 0x200,
        /// <summary> Specifies that the member is a bound to an instance, representing a BoundMemberTracker</summary>
        Bound = 0x400,
        //
        // Summary:
        //     Specifies all member types.
        All = Constructor | Event | Field | Method | Property | Type | Namespace | MethodGroup | TypeGroup | Bound,
    }
}
