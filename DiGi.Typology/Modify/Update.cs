using DiGi.Typology.Classes;
using System.Collections.Generic;

namespace DiGi.Typology
{
    public static partial class Modify
    {
        /// <summary>Updates the given typology based on the provided typology item.
        /// <para>The path carried by the item is relative to <paramref name="typology"/>. Missing intermediate
        /// nodes are created; an existing node is updated in place, keeping its sub-typologies and
        /// its references. When the item carries no path, it is filed under a new index.</para>
        /// </summary>
        /// <param name="typology">The typology to update.</param>
        /// <param name="typologyItem">The typology item containing updated information.</param>
        /// <returns>The updated Typology instance, or null if either input was null.</returns>
        public static Classes.Typology? Update(this Classes.Typology? typology, TypologyItem? typologyItem)
        {
            if (typology is null || typologyItem is null)
            {
                return null;
            }

            if (typologyItem.TypologyPath is not TypologyPath typologyPath || typologyPath.Count == 0)
            {
                if (!typology.TryGetLastIndex(out int index))
                {
                    // Seed -1 so the first generated child lands at index [0], consistent
                    // with the SubTypologies setter and the -1 "no path" sentinel in TypologyPath.Index.
                    index = -1;
                }

                typologyPath = new TypologyPath([index + 1]);
            }

            if (typologyPath.Count == 1)
            {
                Classes.Typology? result = typology.SubTypology(typologyPath);
                if (result is null)
                {
                    result = new Classes.Typology(new TypologyItem(typology.TypologyPath + typologyPath, typologyItem));
                }
                else
                {
                    result.Name = typologyItem.Name;
                    result.Description = typologyItem.Description;
                }

                typology[typologyPath.Index] = result;
                return result;
            }

            if (typologyPath.GetTypologyPath(0, 1) is not TypologyPath typologyPath_Child)
            {
                return null;
            }

            Classes.Typology? typology_Child = typology.SubTypology(typologyPath_Child);
            if (typology_Child is null)
            {
                typology_Child = new Classes.Typology(new TypologyItem(typology.TypologyPath + typologyPath_Child, null, null));
                typology[typologyPath_Child.Index] = typology_Child;
            }

            return typology_Child.Update(new TypologyItem(typologyPath.GetTypologyPath(1, typologyPath.Count - 1), typologyItem));
        }

        /// <summary>Updates or creates a sub-typology using specified path values, name, and description.</summary>
        /// <param name="typology">The typology to update.</param>
        /// <param name="values">The sequence of indices representing the typology path.</param>
        /// <param name="name">The name of the typology.</param>
        /// <param name="description">The description of the typology.</param>
        /// <returns>The updated or created Typology instance, or null if update failed.</returns>
        public static Classes.Typology? Update(this Classes.Typology? typology, IEnumerable<int>? values, string? name, string? description)
        {
            return typology.Update(new TypologyItem(values == null ? null : new TypologyPath(values), name, description));
        }

        /// <summary>Updates or creates a sub-typology using specified name and description at the current level.</summary>
        /// <param name="typology">The typology to update.</param>
        /// <param name="name">The name of the typology.</param>
        /// <param name="description">The description of the typology.</param>
        /// <returns>The updated or created Typology instance, or null if update failed.</returns>
        public static Classes.Typology? Update(this Classes.Typology? typology, string? name, string? description)
        {
            return typology.Update(new TypologyItem(null, name, description));
        }

        /// <summary>Updates or creates a sub-typology using specified name at the current level.</summary>
        /// <param name="typology">The typology to update.</param>
        /// <param name="name">The name of the typology.</param>
        /// <returns>The updated or created Typology instance, or null if update failed.</returns>
        public static Classes.Typology? Update(this Classes.Typology? typology, string? name)
        {
            return typology.Update(new TypologyItem(null, name));
        }

        /// <summary>Updates or creates a sub-typology using specified path values and name.</summary>
        /// <param name="typology">The typology to update.</param>
        /// <param name="values">The sequence of indices representing the typology path.</param>
        /// <param name="name">The name of the typology.</param>
        /// <returns>The updated or created Typology instance, or null if update failed.</returns>
        public static Classes.Typology? Update(this Classes.Typology? typology, IEnumerable<int>? values, string? name)
        {
            return typology.Update(new TypologyItem(values, name));
        }

        /// <summary>Updates the given typology based on the provided typology item.
        /// <para>The path carried by the item is relative to <paramref name="typology"/>. Missing intermediate
        /// nodes are created; an existing node is updated in place, keeping its sub-typologies, its references
        /// and any item fields specific to the derived item type - only the name and description are applied
        /// to it. When the item carries no path, it is filed under a new index.</para>
        /// <para>Every node the method creates is built by the receiving typology's
        /// <see cref="Classes.Typology{TTypology, TTypologyItem}.CreateNode(TTypologyItem, TypologyPath)"/>, so a
        /// derived item type keeps its own fields on the created nodes rather than being flattened to the
        /// base item.</para>
        /// </summary>
        /// <typeparam name="TTypology">The concrete typology type.</typeparam>
        /// <typeparam name="TTypologyItem">The typology item type.</typeparam>
        /// <param name="typology">The typology to update.</param>
        /// <param name="typologyItem">The typology item containing updated information.</param>
        /// <returns>The updated typology instance, or null if either input was null.</returns>
        public static TTypology? Update<TTypology, TTypologyItem>(this TTypology? typology, TTypologyItem? typologyItem) where TTypology : Classes.Typology<TTypology, TTypologyItem> where TTypologyItem : Classes.TypologyItem, new()
        {
            if (typology is null || typologyItem is null)
            {
                return null;
            }

            return Update<TTypology, TTypologyItem>(typology, typologyItem.TypologyPath, typologyItem.Name, typologyItem.Description, typologyItem);
        }

        /// <summary>Updates or creates a sub-typology using specified path values, name, and description.
        /// <para>Missing intermediate nodes are created; an existing node is updated in place, keeping its
        /// sub-typologies, its references and any item fields specific to the derived item type. When
        /// <paramref name="values"/> is null or empty, the node is filed under a new index.</para>
        /// <para>Every node the method creates is built by the receiving typology's
        /// <see cref="Classes.Typology{TTypology, TTypologyItem}.CreateNode(TTypologyItem, TypologyPath)"/>, so a
        /// derived item type keeps its identity on the created nodes.</para>
        /// <para>The item type appears in no parameter, so at a call site on a derived typology the type
        /// arguments cannot be inferred: state them explicitly, or use the argument-free overload the derived
        /// assembly provides.</para>
        /// </summary>
        /// <typeparam name="TTypology">The concrete typology type.</typeparam>
        /// <typeparam name="TTypologyItem">The typology item type.</typeparam>
        /// <param name="typology">The typology to update.</param>
        /// <param name="values">The sequence of indices representing the typology path.</param>
        /// <param name="name">The name of the typology.</param>
        /// <param name="description">The description of the typology.</param>
        /// <returns>The updated or created typology instance, or null if update failed.</returns>
        public static TTypology? Update<TTypology, TTypologyItem>(this TTypology? typology, IEnumerable<int>? values, string? name, string? description) where TTypology : Classes.Typology<TTypology, TTypologyItem> where TTypologyItem : Classes.TypologyItem, new()
        {
            return Update<TTypology, TTypologyItem>(typology, values, name, description, null);
        }

        /// <summary>Updates or creates a sub-typology using specified name and description at the current level.</summary>
        /// <typeparam name="TTypology">The concrete typology type.</typeparam>
        /// <typeparam name="TTypologyItem">The typology item type.</typeparam>
        /// <param name="typology">The typology to update.</param>
        /// <param name="name">The name of the typology.</param>
        /// <param name="description">The description of the typology.</param>
        /// <returns>The updated or created typology instance, or null if update failed.</returns>
        public static TTypology? Update<TTypology, TTypologyItem>(this TTypology? typology, string? name, string? description) where TTypology : Classes.Typology<TTypology, TTypologyItem> where TTypologyItem : Classes.TypologyItem, new()
        {
            return Update<TTypology, TTypologyItem>(typology, null, name, description, null);
        }

        /// <summary>Updates or creates a sub-typology using specified name at the current level.</summary>
        /// <typeparam name="TTypology">The concrete typology type.</typeparam>
        /// <typeparam name="TTypologyItem">The typology item type.</typeparam>
        /// <param name="typology">The typology to update.</param>
        /// <param name="name">The name of the typology.</param>
        /// <returns>The updated or created typology instance, or null if update failed.</returns>
        public static TTypology? Update<TTypology, TTypologyItem>(this TTypology? typology, string? name) where TTypology : Classes.Typology<TTypology, TTypologyItem> where TTypologyItem : Classes.TypologyItem, new()
        {
            return Update<TTypology, TTypologyItem>(typology, null, name, null, null);
        }

        /// <summary>Updates or creates a sub-typology using specified path values and name.</summary>
        /// <typeparam name="TTypology">The concrete typology type.</typeparam>
        /// <typeparam name="TTypologyItem">The typology item type.</typeparam>
        /// <param name="typology">The typology to update.</param>
        /// <param name="values">The sequence of indices representing the typology path.</param>
        /// <param name="name">The name of the typology.</param>
        /// <returns>The updated or created typology instance, or null if update failed.</returns>
        public static TTypology? Update<TTypology, TTypologyItem>(this TTypology? typology, IEnumerable<int>? values, string? name) where TTypology : Classes.Typology<TTypology, TTypologyItem> where TTypologyItem : Classes.TypologyItem, new()
        {
            return Update<TTypology, TTypologyItem>(typology, values, name, null, null);
        }

        /// <summary>Updates or creates a sub-typology at the specified path using the specified name and description.
        /// <para>Missing intermediate nodes are created; an existing node is updated in place, keeping its
        /// sub-typologies, its references and any item fields specific to the derived item type - only the name
        /// and description are applied to it. When <paramref name="values"/> is null or empty, the node is filed
        /// under a new index.</para>
        /// <para>Every created node is built by the receiving typology's
        /// <see cref="Classes.Typology{TTypology, TTypologyItem}.CreateNode(TTypologyItem, TypologyPath)"/>. The
        /// <paramref name="source"/> item, when given, supplies the derived item's fields on the created node -
        /// a derived item keeps its own fields on the created nodes; when null, the created node carries the name
        /// and description only.</para>
        /// </summary>
        /// <typeparam name="TTypology">The concrete typology type.</typeparam>
        /// <typeparam name="TTypologyItem">The typology item type.</typeparam>
        /// <param name="typology">The typology to update.</param>
        /// <param name="values">The sequence of indices representing the typology path, relative to <paramref name="typology"/>.</param>
        /// <param name="name">The name of the typology.</param>
        /// <param name="description">The description of the typology.</param>
        /// <param name="source">The item to take the derived item's fields from when a node is created; null for a node carrying the name and description only.</param>
        /// <returns>The updated or created typology instance, or null when <paramref name="typology"/> is null.</returns>
        public static TTypology? Update<TTypology, TTypologyItem>(this TTypology? typology, IEnumerable<int>? values, string? name, string? description, TTypologyItem? source) where TTypology : Classes.Typology<TTypology, TTypologyItem> where TTypologyItem : Classes.TypologyItem, new()
        {
            if (typology is null)
            {
                return null;
            }

            TypologyPath? typologyPath = values is null ? null : new TypologyPath(values);

            if (typologyPath is null || typologyPath.Count == 0)
            {
                // Seed -1 so the first generated child lands at index [0], consistent
                // with the SubTypologies setter and the -1 "no path" sentinel in TypologyPath.Index.
                int index = typology.TryGetLastIndex(out int index_Max) ? index_Max : -1;
                typologyPath = new TypologyPath([index + 1]);
            }

            // The item the created node takes its fields from: the given source, or a bare item carrying
            // the name and description only when the caller supplied none.
            TTypologyItem source_Leaf = source ?? new TTypologyItem
            {
                Name = name,
                Description = description
            };

            return Update(typology, source_Leaf, typologyPath!);

            static TTypology? Update(TTypology current, TTypologyItem source, TypologyPath relative)
            {
                if (relative.Count == 1)
                {
                    TTypology? result = current.SubTypology(relative);

                    if (result is null)
                    {
                        result = current.CreateNode(source, current.TypologyPath + relative);
                    }
                    else
                    {
                        result.Name = source.Name;
                        result.Description = source.Description;
                    }

                    current[relative.Index] = result;
                    return result;
                }

                if (relative.GetTypologyPath(0, 1) is not TypologyPath relative_First
                    || relative.GetTypologyPath(1, relative.Count - 1) is not TypologyPath relative_Rest)
                {
                    return null;
                }

                TTypology? current_Child = current.SubTypology(relative_First);

                if (current_Child is null)
                {
                    current_Child = current.CreateNode(null, current.TypologyPath + relative_First);
                    current[relative_First.Index] = current_Child;
                }

                return Update(current_Child, source, relative_Rest);
            }
        }
    }
}
