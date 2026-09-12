using System.Collections.Generic;

namespace DiGi.Typology
{
    public static partial class Modify
    {
        /// <summary>
        /// Updates an existing direct child of the receiving typology whose name matches, or creates a new one when no match exists.
        /// <para>Matching is limited to the direct children of <paramref name="in"/>; their sub-trees are not searched. When a match is found, only <paramref name="description"/> is applied to the matched child; <paramref name="values"/> and <paramref name="name"/> are ignored, and if several children share the name, the first one is used. When no match exists, a new child is created from <paramref name="values"/>, <paramref name="name"/> and <paramref name="description"/>.</para>
        /// </summary>
        /// <param name="in">The parent typology whose direct children are searched.</param>
        /// <param name="values">Integer values used to create the new child when no match is found; ignored when a match exists.</param>
        /// <param name="name">The name matched against the direct children of <paramref name="in"/>; also the name assigned to a new child.</param>
        /// <param name="description">The description applied to the matched child, or assigned to a new child.</param>
        /// <param name="out">When this method returns, contains the updated or newly created child typology if successful; otherwise, null.</param>
        /// <returns>True if a direct child was updated or created; otherwise, false.</returns>
        public static bool TryUpdateByName(this Classes.Typology? @in, IEnumerable<int>? values, string? name, string? description, out Classes.Typology? @out)
        {
            @out = null;

            if (name is null || @in is null)
            {
                return false;
            }

            if (!@in.TryGetTypologies(name, out List<Classes.Typology>? typologies) || typologies == null || typologies.Count == 0)
            {
                @out = @in.Update(values, name, description);
            }
            else
            {
                @out = typologies[0];
                @out.Description = description;
            }

            if (@out is null)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Updates an existing direct child of the receiving typology whose name matches, or creates a new one when no match exists.
        /// <para>Matching is limited to the direct children of <paramref name="in"/>; their sub-trees are not searched. When a match is found, only <paramref name="description"/> is applied to the matched child; <paramref name="values"/> and <paramref name="name"/> are ignored, and if several children share the name, the first one is used. When no match exists, a new child is created from <paramref name="values"/>, <paramref name="name"/> and <paramref name="description"/>.</para>
        /// <para>The new child is built by the receiving typology's <see cref="Classes.Typology{TTypology, TTypologyItem}.CreateNode(TTypologyItem, Classes.TypologyPath)"/>,
        /// so a derived item type keeps its identity on the created node.</para>
        /// <para>The item type appears in no parameter, so at a call site on a derived typology the type arguments cannot be inferred: state them explicitly,
        /// or use the argument-free overload the derived assembly provides.</para>
        /// </summary>
        /// <typeparam name="TTypology">The concrete typology type.</typeparam>
        /// <typeparam name="TTypologyItem">The typology item type.</typeparam>
        /// <param name="in">The parent typology whose direct children are searched.</param>
        /// <param name="values">Integer values used to create the new child when no match is found; ignored when a match exists.</param>
        /// <param name="name">The name matched against the direct children of <paramref name="in"/>; also the name assigned to a new child.</param>
        /// <param name="description">The description applied to the matched child, or assigned to a new child.</param>
        /// <param name="out">When this method returns, contains the updated or newly created child typology if successful; otherwise, null.</param>
        /// <returns>True if a direct child was updated or created; otherwise, false.</returns>
        public static bool TryUpdateByName<TTypology, TTypologyItem>(this TTypology? @in, IEnumerable<int>? values, string? name, string? description, out TTypology? @out) where TTypology : Classes.Typology<TTypology, TTypologyItem> where TTypologyItem : Classes.TypologyItem, new()
        {
            @out = null;

            if (name is null || @in is null)
            {
                return false;
            }

            if (!@in.TryGetTypologies(name, out List<TTypology>? typologies) || typologies is null || typologies.Count == 0)
            {
                // Explicit type arguments: inference from a type-parameter receiver does not chain through its
                // constraints, so the generic Update would not bind with inferred arguments here (CS0411).
                @out = Update<TTypology, TTypologyItem>(@in, values, name, description);
            }
            else
            {
                @out = typologies[0];
                @out.Description = description;
            }

            if (@out is null)
            {
                return false;
            }

            return true;
        }
    }
}