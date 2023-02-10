using System;

namespace Penguin.Templating.Abstractions.Interfaces
{
    public interface IModifiableEntity
    {
        DateTime? DateModified { get; }

        Guid Guid { get; }
    }
}