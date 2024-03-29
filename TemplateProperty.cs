﻿using Penguin.Templating.Abstractions.Interfaces;
using System.Collections.Generic;

namespace Penguin.Templating.Abstractions
{
    public class TemplateProperty : ITemplateProperty
    {
        /// <summary>
        /// A collection of child properties
        /// </summary>
        public IList<ITemplateProperty> Children { get; } = new List<ITemplateProperty>();

        /// <summary>
        /// Adds a child template property
        /// </summary>
        /// <param name="toAdd">The child to add</param>
        public void AddChild(ITemplateProperty toAdd)
        {
            Children.Add(toAdd);
        }

        IEnumerable<ITemplateProperty> ITemplateProperty.Children => Children;

        /// <summary>
        /// The name to display in any editor used to alter this object
        /// </summary>
        public string DisplayName { get; set; }

        public string MacroBody { get; set; }
    }
}