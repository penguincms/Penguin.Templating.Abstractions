using System;
using System.Collections.Generic;
using System.Text;

namespace Penguin.Templating.Abstractions.Interfaces
{
    public interface IModifiableEntity
    {
        DateTime? DateModified { get; }
        Guid Guid { get; }
    }
}