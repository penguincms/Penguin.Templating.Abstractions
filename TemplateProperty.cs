using Penguin.Templating.Abstractions.Interfaces;
using System.Collections.Generic;

namespace Penguin.Templating.Abstractions
{
    public class TemplateProperty : ITemplateProperty
    {
        public List<ITemplateProperty> Children { get; set; }
        IEnumerable<ITemplateProperty> ITemplateProperty.Children => Children;
        public string DisplayName { get; set; }
        public string MacroBody { get; set; }
    }
}