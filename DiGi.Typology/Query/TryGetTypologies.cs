using DiGi.Typology.Classes;
using System.Collections.Generic;

namespace DiGi.Typology
{
    public static partial class Query
    {
        /// <summary>Attempts to retrieve the direct children, of the typology found at the specified path, that carry the specified name.</summary>
        /// <typeparam name="TTypology">The concrete typology type.</typeparam>
        /// <typeparam name="TTypologyItem">The typology item type.</typeparam>
        /// <param name="typology">The typology the path is resolved against.</param>
        /// <param name="typologyPath">The path to search within.</param>
        /// <param name="name">The name of the typologies to find.</param>
        /// <param name="typologies">When this method returns, contains a list of matching typologies if successful; otherwise, null.</param>
        /// <returns>True if one or more matching typologies were found; otherwise, false.</returns>
        public static bool TryGetTypologies<TTypology, TTypologyItem>(this Classes.Typology<TTypology, TTypologyItem>? typology, TypologyPath? typologyPath, string name, out List<TTypology>? typologies) where TTypology : Classes.Typology<TTypology, TTypologyItem> where TTypologyItem : Classes.TypologyItem, new()
        {
            typologies = null;

            if (typology is null || typologyPath is null)
            {
                return false;
            }

            if (typology.SubTypology(typologyPath) is not TTypology typology_Temp)
            {
                return false;
            }

            typologies = [];

            if (typology_Temp.SubTypologies is List<TTypology> subTypologies)
            {
                foreach (TTypology subTypology in subTypologies)
                {
                    if (subTypology.Name != name)
                    {
                        continue;
                    }

                    typologies.Add(subTypology);
                }
            }

            if (typologies.Count == 0)
            {
                typologies = null;
                return false;
            }

            return true;
        }

        /// <summary>Attempts to retrieve the direct children, of the typology found at the specified index values, that carry the specified name.</summary>
        /// <typeparam name="TTypology">The concrete typology type.</typeparam>
        /// <typeparam name="TTypologyItem">The typology item type.</typeparam>
        /// <param name="typology">The typology the path is resolved against.</param>
        /// <param name="values">The sequence of indices representing the typology path.</param>
        /// <param name="name">The name of the typologies to find.</param>
        /// <param name="typologies">When this method returns, contains a list of matching typologies if successful; otherwise, null.</param>
        /// <returns>True if one or more matching typologies were found; otherwise, false.</returns>
        public static bool TryGetTypologies<TTypology, TTypologyItem>(this Classes.Typology<TTypology, TTypologyItem>? typology, IEnumerable<int> values, string name, out List<TTypology>? typologies) where TTypology : Classes.Typology<TTypology, TTypologyItem> where TTypologyItem : Classes.TypologyItem, new()
        {
            typologies = null;

            if (typology is null || values == null)
            {
                return false;
            }

            return typology.TryGetTypologies(new TypologyPath(values), name, out typologies);
        }

        /// <summary>Attempts to retrieve the direct children of the given typology that carry the specified name.</summary>
        /// <typeparam name="TTypology">The concrete typology type.</typeparam>
        /// <typeparam name="TTypologyItem">The typology item type.</typeparam>
        /// <param name="typology">The typology whose direct children are searched.</param>
        /// <param name="name">The name of the typologies to find.</param>
        /// <param name="typologies">When this method returns, contains a list of matching typologies if successful; otherwise, null.</param>
        /// <returns>True if one or more matching typologies were found; otherwise, false.</returns>
        public static bool TryGetTypologies<TTypology, TTypologyItem>(this Classes.Typology<TTypology, TTypologyItem>? typology, string name, out List<TTypology>? typologies) where TTypology : Classes.Typology<TTypology, TTypologyItem> where TTypologyItem : Classes.TypologyItem, new()
        {
            return typology.TryGetTypologies(new TypologyPath((IEnumerable<int>)[]), name, out typologies);
        }
    }
}
