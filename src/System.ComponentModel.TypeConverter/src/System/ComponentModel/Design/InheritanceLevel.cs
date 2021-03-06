// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.ComponentModel
{
    /// <summary>
    ///    <para>
    ///       Specifies
    ///       numeric IDs for different inheritance levels.
    ///    </para>
    /// </summary>
    public enum InheritanceLevel
    {
        /// <summary>
        ///      Indicates that the object is inherited.
        /// </summary>
        Inherited = 1,

        /// <summary>
        ///    <para>
        ///       Indicates that the object is inherited, but has read-only access.
        ///    </para>
        /// </summary>
        InheritedReadOnly = 2,

        /// <summary>
        ///      Indicates that the object is not inherited.
        /// </summary>
        NotInherited = 3,
    }
}

