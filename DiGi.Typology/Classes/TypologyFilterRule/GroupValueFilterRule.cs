using DiGi.Typology.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Typology.Classes
{
    /// <summary>
    /// Represents a group value filter rule.
    /// </summary>
    public abstract class GroupValueFilterRule : TypologyFilterRule, ITypologyFilterRule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupValueFilterRule"/> class with a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the filter rule data.</param>
        public GroupValueFilterRule(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupValueFilterRule"/> class.
        /// </summary>
        public GroupValueFilterRule()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupValueFilterRule"/> class by copying another instance.
        /// </summary>
        /// <param name="groupValueFilterRule">The source filter rule to copy.</param>
        public GroupValueFilterRule(GroupValueFilterRule groupValueFilterRule)
            : base(groupValueFilterRule)
        {
        }
    }
}