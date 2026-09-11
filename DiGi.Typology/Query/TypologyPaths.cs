using DiGi.Typology.Classes;
using System.Collections.Generic;

namespace DiGi.Typology
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves the paths of the sub-typologies of the given typology, optionally including nested ones.
        /// <para>The paths are the ones the sub-typologies report themselves, which may differ from the keys
        /// they are filed under - see <see cref="Classes.Typology{TTypology, TTypologyItem}.SubTypologies"/>. A sub-typology carrying
        /// no path contributes nothing.</para>
        /// </summary>
        /// <typeparam name="TTypology">The concrete typology type.</typeparam>
        /// <typeparam name="TTypologyItem">The typology item type.</typeparam>
        /// <param name="typology">The typology whose sub-typology paths are collected.</param>
        /// <param name="includeNested">A value indicating whether to recursively retrieve paths from nested typologies.</param>
        /// <returns>A <see cref="List{T}"/> of <see cref="TypologyPath"/> objects, empty when no sub-typologies exist.</returns>
        public static List<TypologyPath> TypologyPaths<TTypology, TTypologyItem>(this Classes.Typology<TTypology, TTypologyItem>? typology, bool includeNested = false) where TTypology : Classes.Typology<TTypology, TTypologyItem> where TTypologyItem : Classes.TypologyItem, new()
        {
            List<TypologyPath> result = [];

            if (typology?.SubTypologies is not List<TTypology> subTypologies)
            {
                return result;
            }

            foreach (TTypology subTypology in subTypologies)
            {
                if (subTypology?.TypologyPath is not TypologyPath typologyPath)
                {
                    continue;
                }

                result.Add(typologyPath);

                if (includeNested)
                {
                    result.AddRange(subTypology.TypologyPaths(includeNested));
                }
            }

            return result;
        }
    }
}
