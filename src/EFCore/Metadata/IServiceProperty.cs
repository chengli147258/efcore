// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

#nullable enable

namespace Microsoft.EntityFrameworkCore.Metadata
{
    /// <summary>
    ///     <para>
    ///         A <see cref="IReadOnlyPropertyBase" /> in the Entity Framework model that represents an
    ///         injected service from the <see cref="DbContext" />.
    ///     </para>
    ///     <para>
    ///         This interface is used after the model building is finished and doesn't allow the metadata to be modified.
    ///     </para>
    /// </summary>
    public interface IServiceProperty : IReadOnlyServiceProperty, IPropertyBase
    {
        /// <summary>
        ///     Gets the type that this property belongs to.
        /// </summary>
        new IEntityType DeclaringEntityType { get; }
    }
}
