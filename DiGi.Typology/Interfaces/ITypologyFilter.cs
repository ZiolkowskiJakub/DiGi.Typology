using DiGi.Core.Interfaces;

namespace DiGi.Typology.Interfaces
{
    /// <summary>
    /// Defines the contract for a typology filter that can be serialized and is a typology object.
    /// </summary>
    public interface ITypologyFilter : ISerializableObject, ITypologyObject
    {
        /// <summary>
        /// Gets or sets the rule associated with this typology filter.
        /// </summary>
        ITypologyFilterRule? Rule { get; set; }
    }

    /// <summary>
    /// Defines the generic contract for a nested typology filter.
    /// </summary>
    /// <typeparam name="TTypologyFilter">The specific type of the nested filter.</typeparam>
    public interface ITypologyFilter<TTypologyFilter> : ITypologyFilter where TTypologyFilter : ITypologyFilter<TTypologyFilter>
    {
        /// <summary>
        /// Gets or sets the nested filter to be applied sequentially.
        /// </summary>
        TTypologyFilter? Filter { get; set; }
    }

    /// <summary>
    /// Defines the generic contract for a typology filter that holds a specific value.
    /// </summary>
    /// <typeparam name="TTypologyFilter">The specific type of the nested filter.</typeparam>
    /// <typeparam name="TValue">The type of value associated with this filter.</typeparam>
    public interface ITypologyFilter<TTypologyFilter, TValue> : ITypologyFilter<TTypologyFilter> where TTypologyFilter : ITypologyFilter<TTypologyFilter>
    {
        /// <summary>
        /// Gets or sets the value associated with this typology filter.
        /// </summary>
        TValue? Value { get; set; }
    }
}