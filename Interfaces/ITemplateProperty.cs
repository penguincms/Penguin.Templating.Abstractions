using System.Collections.Generic;

namespace Penguin.Templating.Abstractions.Interfaces
{
    public interface ITemplateProperty
    {
        IEnumerable<ITemplateProperty> Children { get; }

        string DisplayName { get; }

        string MacroBody { get; }
    }
}