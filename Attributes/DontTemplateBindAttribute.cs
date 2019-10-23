using System;
using System.Collections.Generic;
using System.Text;

namespace Penguin.Templating.Abstractions.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class DontTemplateBindAttribute : Attribute
    {
    }
}