using System.Collections.Generic;

namespace DiGi.Typology
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves the set of references associated with the given typology, optionally including those
        /// carried by its nested typologies.
        /// <para>With <paramref name="includeNested"/> false this is the content of
        /// <see cref="Classes.Typology{TTypology, TTypologyItem}.References"/> as a set; the recursive form is what this method adds.
        /// It is named for the set it returns because the typology already exposes a References property.</para>
        /// </summary>
        /// <typeparam name="TTypology">The concrete typology type.</typeparam>
        /// <typeparam name="TTypologyItem">The typology item type.</typeparam>
        /// <param name="typology">The typology whose references are collected.</param>
        /// <param name="includeNested">A value indicating whether to include references from nested typologies.</param>
        /// <returns>A <see cref="HashSet{T}"/> containing the references, empty when the typology is null.</returns>
        public static HashSet<string> ReferenceSet<TTypology, TTypologyItem>(this Classes.Typology<TTypology, TTypologyItem>? typology, bool includeNested = false) where TTypology : Classes.Typology<TTypology, TTypologyItem> where TTypologyItem : Classes.TypologyItem, new()
        {
            HashSet<string> result = [];

            if (typology is null)
            {
                return result;
            }

            result.UnionWith(typology.References);

            if (!includeNested || typology.SubTypologies is not List<TTypology> subTypologies)
            {
                return result;
            }

            foreach (TTypology subTypology in subTypologies)
            {
                result.UnionWith(subTypology.ReferenceSet(includeNested));
            }

            return result;
        }
    }
}
