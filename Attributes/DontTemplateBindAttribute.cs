using System;

namespace Penguin.Templating.Abstractions.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public sealed class DontTemplateBindAttribute : Attribute
    {
    }
}