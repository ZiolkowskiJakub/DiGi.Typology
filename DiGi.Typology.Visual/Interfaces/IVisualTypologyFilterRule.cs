using DiGi.Typology.Interfaces;
using DiGi.Typology.Visual.Classes;

namespace DiGi.Typology.Visual.Interfaces
{
    /// <summary>
    /// Defines the contract for a typology filter rule that carries the appearance of each of its buckets.
    /// <para>Where a plain <see cref="ITypologyFilterRule"/> resolves a value to a rule-data bucket, a visual one also
    /// exposes the bucket appearances, in a <see cref="TypologyAppearanceCollection"/> keyed as
    /// <see cref="Query.Key(object)"/> renders the bucket, so a client can render a resolved value.</para>
    /// </summary>
    public interface IVisualTypologyFilterRule : ITypologyVisualSerializableObject, ITypologyFilterRule
    {
        /// <summary>
        /// Gets the appearances of the buckets of this rule, keyed by bucket. Never null.
        /// </summary>
        TypologyAppearanceCollection TypologyAppearanceCollection { get; }
    }
}