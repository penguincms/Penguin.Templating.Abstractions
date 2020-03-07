﻿using System;

namespace Penguin.Templating.Abstractions
{
    /// <summary>
    /// Contains the information required to generate the model information, parameter name, and set the value to render
    /// </summary>
    public struct TemplateParameter
    {
        /// <summary>
        /// The name of the parameter to use when naming the model property
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The Type of the parameter, used to define the model property type
        /// </summary>
        public Type Type { get; set; }

        /// <summary>
        /// The value to bind to the Tuple that is generated with the intent of being passed into the
        /// newly generated (unless cached) template
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// Constructs a new instance of this class with the provided values
        /// </summary>
        /// <param name="type">The Type of the parameter, used to define the model property type</param>
        /// <param name="name">The name of the parameter to use when naming the model property</param>
        /// <param name="value">
        /// The value to bind to the Tuple that is generated with the intent of being passed into the
        /// newly generated (unless cached) template
        /// </param>
        public TemplateParameter(Type type, string name, object value)
        {
            this.Type = type;
            this.Name = name;
            this.Value = value;
        }
    }
}