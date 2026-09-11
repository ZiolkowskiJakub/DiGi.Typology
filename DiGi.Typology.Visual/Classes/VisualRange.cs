using DiGi.Core.Classes;
using DiGi.Typology.Classes;
using DiGi.Typology.Visual.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Typology.Visual.Classes
{
    /// <summary>
    /// A <see cref="Range{T}"/> carrying the appearance of the bucket it defines.
    /// <para>Rides inside the existing <see cref="IntegerRangeFilterRule"/> and <see cref="DoubleRangeFilterRule"/>
    /// unchanged: the rule keys on <see cref="Range{T}.Min"/> and stores whatever <see cref="Range{T}"/> subtype it is
    /// given, so there is no Visual rule class. <see cref="RangeValueFilterRule{TValueType}.RuleData(object)"/> wraps the
    /// matched instance itself, so a consumer reads the appearance back as <c>ruleData.Range as VisualRange&lt;T&gt;</c>.</para>
    /// <para>The appearance is metadata and takes no part in equality or hashing: two ranges with the same bounds are
    /// equal whatever they look like, which keeps bucket identity a property of the range alone.</para>
    /// </summary>
    /// <typeparam name="T">The type of the values in the range.</typeparam>
    public class VisualRange<T> : Range<T>, ITypologyVisualSerializableObject
    {
        [JsonInclude, JsonPropertyName(nameof(Appearance))]
        private TypologyAppearance? appearance;

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualRange{T}"/> class with specified boundary values and appearance.
        /// </summary>
        /// <param name="value_1">The first boundary value.</param>
        /// <param name="value_2">The second boundary value.</param>
        /// <param name="appearance">The appearance of the bucket; it is cloned.</param>
        public VisualRange(T? value_1, T? value_2, TypologyAppearance? appearance)
            : base(value_1, value_2)
        {
            this.appearance = Core.Query.Clone(appearance);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualRange{T}"/> class from a plain range and an appearance.
        /// </summary>
        /// <param name="range">The range whose bounds are copied.</param>
        /// <param name="appearance">The appearance of the bucket; it is cloned.</param>
        public VisualRange(Range<T>? range, TypologyAppearance? appearance)
            : base(range)
        {
            this.appearance = Core.Query.Clone(appearance);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualRange{T}"/> class by copying an existing visual range.
        /// </summary>
        /// <param name="visualRange">The visual range to copy.</param>
        public VisualRange(VisualRange<T>? visualRange)
            : base(visualRange)
        {
            if (visualRange is not null)
            {
                appearance = Core.Query.Clone(visualRange.appearance);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualRange{T}"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize the range from.</param>
        public VisualRange(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets or sets the appearance of the bucket this range defines, or null when it has none.
        /// </summary>
        [JsonIgnore]
        public TypologyAppearance? Appearance
        {
            get
            {
                return appearance;
            }

            set
            {
                appearance = value;
            }
        }
    }
}
