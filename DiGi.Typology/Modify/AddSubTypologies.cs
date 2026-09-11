using System.Collections.Generic;

namespace DiGi.Typology
{
    public static partial class Modify
    {
        /// <summary>
        /// Files the given sub-typologies under the given typology.
        /// <para>Each sub-typology is cloned and then filed under the last index of its own path. One
        /// carrying no path, or one whose index is already taken, is filed under the next free index
        /// rather than being discarded, so the assigned key may differ from the path the sub-typology
        /// reports. Sub-typologies already filed are kept; the next free index is resolved against them.</para>
        /// </summary>
        /// <typeparam name="TTypology">The concrete typology type.</typeparam>
        /// <typeparam name="TTypologyItem">The typology item type.</typeparam>
        /// <param name="typology">The typology to file the sub-typologies under.</param>
        /// <param name="subTypologies">The sub-typologies to file; null entries are skipped.</param>
        /// <returns>The number of sub-typologies filed; 0 when either argument is null.</returns>
        public static int AddSubTypologies<TTypology, TTypologyItem>(this Classes.Typology<TTypology, TTypologyItem>? typology, IEnumerable<TTypology?>? subTypologies) where TTypology : Classes.Typology<TTypology, TTypologyItem> where TTypologyItem : Classes.TypologyItem, new()
        {
            if (typology is null || subTypologies is null)
            {
                return 0;
            }

            if (!typology.TryGetLastIndex(out int index_Max))
            {
                index_Max = -1;
            }

            int result = 0;

            foreach (TTypology? subTypology in subTypologies)
            {
                if (subTypology is null)
                {
                    continue;
                }

                if (Core.Query.Clone(subTypology) is not TTypology subTypology_Temp)
                {
                    continue;
                }

                int index = subTypology_Temp.TypologyPath?.Index ?? -1;

                if (index < 0 || typology[index] is not null)
                {
                    index = index_Max + 1;
                }

                typology[index] = subTypology_Temp;
                result++;

                if (index > index_Max)
                {
                    index_Max = index;
                }
            }

            return result;
        }
    }
}
