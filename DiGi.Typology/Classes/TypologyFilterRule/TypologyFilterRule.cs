using DiGi.Core.Classes;
using DiGi.Typology.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Typology.Classes
{
    /// <summary>
    /// Represents a base abstract class for typology filter rules.
    /// </summary>
    public abstract class TypologyFilterRule : SerializableObject, ITypologyFilterRule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TypologyFilterRule"/> class with a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing filter rule data.</param>
        public TypologyFilterRule(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypologyFilterRule"/> class.
        /// </summary>
        public TypologyFilterRule()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypologyFilterRule"/> class by copying another instance.
        /// </summary>
        /// <param name="typologyFilterRule">The source filter rule to copy from.</param>
        public TypologyFilterRule(TypologyFilterRule typologyFilterRule)
            : base(typologyFilterRule)
        {
        }
    }
}