using DiGi.Core.Classes;
using DiGi.Typology.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Typology.Classes
{
    /// <summary>
    /// Represents a base abstract class for typology filter rule data.
    /// </summary>
    /// <typeparam name="TTypologyFilterRuleData">The specific type of the typology filter rule data.</typeparam>
    public abstract class TypologyFilterRuleData<TTypologyFilterRuleData> : SerializableObject, ITypologyFilterRuleData<TTypologyFilterRuleData> where TTypologyFilterRuleData : TypologyFilterRuleData<TTypologyFilterRuleData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TypologyFilterRuleData{TTypologyFilterRuleData}"/> class with a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the filter rule data.</param>
        public TypologyFilterRuleData(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypologyFilterRuleData{TTypologyFilterRuleData}"/> class.
        /// </summary>
        public TypologyFilterRuleData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypologyFilterRuleData{TTypologyFilterRuleData}"/> class by copying another instance.
        /// </summary>
        /// <param name="typologyFilterRuleData">The source filter rule data to copy from.</param>
        public TypologyFilterRuleData(TypologyFilterRuleData<TTypologyFilterRuleData> typologyFilterRuleData)
            : base(typologyFilterRuleData)
        {
        }

        /// <summary>
        /// Compares this filter rule data instance to another for equality.
        /// </summary>
        /// <param name="typologyFilterRuleData">The filter rule data to compare.</param>
        /// <returns>True if they are equal; otherwise, false.</returns>
        public abstract bool Equals(TTypologyFilterRuleData typologyFilterRuleData);
    }
}