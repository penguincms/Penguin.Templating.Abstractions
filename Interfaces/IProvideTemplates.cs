using System.Collections.Generic;

namespace Penguin.Templating.Abstractions.Interfaces
{
    public interface IProvideTemplates
    {
        IEnumerable<ITemplateDefinition> GetTemplateDefinitions();
    }
}