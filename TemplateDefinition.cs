using Penguin.Templating.Abstractions.Interfaces;
using System;
using System.Collections.Generic;

namespace Penguin.Templating.Abstractions
{
    public class TemplateDefinition : ITemplateDefinition
    {
        public IList<ITemplateProperty> Children { get; } = new List<ITemplateProperty>();

        IEnumerable<ITemplateProperty> ITemplateDefinition.Children => Children;

        public string DisplayName { get; set; }

        public Type Handler { get; set; }

        public string Target { get; set; }

        public TemplateDefinition(string displayName, Type handler, object target)
        {
            if (target is null)
            {
                throw new ArgumentNullException(nameof(target));
            }

            DisplayName = displayName;
            Handler = handler;
            Target = target.ToString();
        }

        public TemplateDefinition(string displayName, Type handler) : this(displayName, handler, displayName)
        {
        }
    }
}