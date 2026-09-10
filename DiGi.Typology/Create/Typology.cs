using DiGi.Typology.Classes;
using System.Collections.Generic;

namespace DiGi.Typology
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a typology carrying the given item and the given sub-typologies.
        /// <para>Each sub-typology is cloned and then filed under the last index of its own path. One
        /// carrying no path, or one whose index is already taken, is filed under the next free index
        /// rather than being discarded, so the assigned key may differ from the path the sub-typology
        /// reports. Resolving those indexes is why this is a factory rather than a constructor.</para>
        /// </summary>
        /// <param name="typologyItem">The typology item to assign.</param>
        /// <param name="subTypologies">A collection of sub-typologies to associate with the new instance.</param>
        /// <returns>The created typology, or null when both arguments are null.</returns>
        public static Classes.Typology? Typology(this TypologyItem? typologyItem, IEnumerable<Classes.Typology>? subTypologies)
        {
            if (typologyItem is null && subTypologies is null)
            {
                return null;
            }

            Classes.Typology result = new(typologyItem);

            if (subTypologies is null)
            {
                return result;
            }

            int index_Max = -1;

            foreach (Classes.Typology subTypology in subTypologies)
            {
                if (subTypology is null)
                {
                    continue;
                }

                if (Core.Query.Clone(subTypology) is not Classes.Typology subTypology_Temp)
                {
                    continue;
                }

                int index = subTypology_Temp.TypologyPath?.Index ?? -1;

                if (index < 0 || result[index] is not null)
                {
                    index = index_Max + 1;
                }

                result[index] = subTypology_Temp;

                if (index > index_Max)
                {
                    index_Max = index;
                }
            }

            return result;
        }
    }
}
