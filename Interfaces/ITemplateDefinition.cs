using System;
using System.Collections.Generic;

namespace Penguin.Templating.Abstractions.Interfaces
{
    public interface ITemplateDefinition
    {
        IEnumerable<ITemplateProperty> Children { get; }

        string DisplayName { get; }

        Type Handler { get; }

        string Target { get; }
    }
}