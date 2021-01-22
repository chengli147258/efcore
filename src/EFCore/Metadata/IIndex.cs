// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Infrastructure;

#nullable enable

namespace Microsoft.EntityFrameworkCore.Metadata
{
    /// <summary>
    ///     <para>
    ///         Represents an index on a set of properties.
    ///     </para>
    ///     <para>
    ///         This interface is used after the model building is finished and doesn't allow the metadata to be modified.
    ///     </para>
    /// </summary>
    public interface IIndex : IReadOnlyIndex, IAnnotatable
    {
        /// <summary>
        ///     Gets the properties that this index is defined on.
        /// </summary>
        new IReadOnlyList<IProperty> Properties { get; }

        /// <summary>
        ///     Gets the entity type the index is defined on. This may be different from the type that <see cref="Properties" />
        ///     are defined on when the index is defined a derived type in an inheritance hierarchy (since the properties
        ///     may be defined on a base type).
        /// </summary>
        new IEntityType DeclaringEntityType { get; }
    }
}
