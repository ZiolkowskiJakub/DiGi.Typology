using DiGi.Core.Classes;
using DiGi.Typology.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Typology.Classes
{
    /// <summary>
    /// Represents a generic abstract base class for typology filters.
    /// </summary>
    /// <typeparam name="TTypologyFilter">The specific subclass type of the typology filter.</typeparam>
    public abstract class TypologyFilter<TTypologyFilter> : SerializableObject, ITypologyFilter<TTypologyFilter> where TTypologyFilter : TypologyFilter<TTypologyFilter>
    {
        /// <summary>
        /// Gets or sets the rule associated with this typology filter.
        /// </summary>
        public ITypologyFilterRule? Rule { get; set; }

        /// <summary>
        /// Gets or sets the nested typology filter to apply sequentially.
        /// </summary>
        public TTypologyFilter? Filter { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypologyFilter{TTypologyFilter}"/> class.
        /// </summary>
        protected TypologyFilter()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypologyFilter{TTypologyFilter}"/> class with a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing filter data.</param>
        protected TypologyFilter(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypologyFilter{TTypologyFilter}"/> class by copying another instance.
        /// </summary>
        /// <param name="typologyFilter_Other">The source filter instance to copy from.</param>
        protected TypologyFilter(TypologyFilter<TTypologyFilter>? typologyFilter_Other)
            : base(typologyFilter_Other)
        {
            if (typologyFilter_Other != null)
            {
                Filter = Core.Query.Clone(typologyFilter_Other.Filter);
                Rule = Core.Query.Clone(typologyFilter_Other.Rule);
            }
        }
    }

    /// <summary>
    /// Represents a generic abstract base class for typology filters that hold a specific value.
    /// </summary>
    /// <typeparam name="TTypologyFilter">The specific subclass type of the typology filter.</typeparam>
    /// <typeparam name="TValue">The type of the filter value.</typeparam>
    public abstract class TypologyFilter<TTypologyFilter, TValue> : TypologyFilter<TTypologyFilter>, ITypologyFilter<TTypologyFilter, TValue> where TTypologyFilter : TypologyFilter<TTypologyFilter>
    {
        /// <summary>
        /// Gets or sets the value associated with this typology filter.
        /// </summary>
        public TValue? Value { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypologyFilter{TTypologyFilter, TValue}"/> class.
        /// </summary>
        protected TypologyFilter()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypologyFilter{TTypologyFilter, TValue}"/> class with a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing filter data.</param>
        protected TypologyFilter(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypologyFilter{TTypologyFilter, TValue}"/> class by copying another instance.
        /// </summary>
        /// <param name="typologyFilter">The source filter instance to copy from.</param>
        protected TypologyFilter(TypologyFilter<TTypologyFilter, TValue>? typologyFilter)
            : base(typologyFilter)
        {
            if (typologyFilter != null && typologyFilter.Value != null)
            {
                Value = typologyFilter.Value;
            }
        }
    }
}