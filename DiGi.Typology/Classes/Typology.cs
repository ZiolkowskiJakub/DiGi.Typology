using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Typology.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Typology.Classes
{
    /// <summary>
    /// Base of a typology tree: a node carrying a typology item, a set of references and the sub-typologies
    /// filed under it by index. Self-typed so that a specialised item type gets its own tree without copying
    /// the class.
    /// <para>Derive as <c>class X : Typology&lt;X, XItem&gt;</c> and chain the four protected constructors -
    /// the parameterless one, the item one, the copy one and the JSON one - as the public constructors of
    /// <typeparamref name="TTypology"/>. The JSON <c>_type</c> discriminator carries the concrete type name,
    /// so deserialization needs the <see cref="JsonObject"/> constructor on the concrete type.</para>
    /// <para>Every sub-typology, comparison operand and equality operand is a <typeparamref name="TTypology"/>;
    /// the item comparison goes through the virtual <see cref="TypologyItem.Equals(TypologyItem)"/> and
    /// <see cref="TypologyItem.CompareTo(TypologyItem)"/>, so an item type adding fields overrides those two
    /// together with <see cref="object.GetHashCode"/>.</para>
    /// </summary>
    /// <typeparam name="TTypology">The concrete typology type - the type of every node of the tree.</typeparam>
    /// <typeparam name="TTypologyItem">The typology item type. It needs a public parameterless constructor
    /// because the <see cref="Name"/> and <see cref="Description"/> setters create an empty item when the
    /// node has none.</typeparam>
    public abstract class Typology<TTypology, TTypologyItem> : SerializableObject, ITypologySerializableObject, INamedObject, IDescribableObject, IComparable<TTypology>, IEquatable<TTypology> where TTypology : Typology<TTypology, TTypologyItem> where TTypologyItem : TypologyItem, new()
    {
        [JsonInclude, JsonPropertyName(nameof(References))]
        private readonly HashSet<string> references = [];

        [JsonIgnore]
        private readonly Dictionary<int, TTypology> subTypologies = [];

        [JsonInclude, JsonPropertyName(nameof(TypologyItem))]
        private TTypologyItem? typologyItem;

        /// <summary>
        /// Initializes a new, empty instance of the <see cref="Typology{TTypology, TTypologyItem}"/> class.
        /// </summary>
        protected Typology()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Typology{TTypology, TTypologyItem}"/> class with a
        /// specified typology item.
        /// <para>Sub-typologies are not taken here: filing each one resolves an index against the indexes
        /// already taken, which does not belong in a constructor - a <c>Create</c> factory does that, see
        /// <see cref="Create.Typology(TypologyItem, IEnumerable{Typology})"/>.</para>
        /// </summary>
        /// <param name="typologyItem">The typology item to assign; it is cloned.</param>
        protected Typology(TTypologyItem? typologyItem)
        {
            this.typologyItem = Core.Query.Clone(typologyItem);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Typology{TTypology, TTypologyItem}"/> class by cloning
        /// an existing typology: the item, the references and every sub-typology are copied, not aliased.
        /// </summary>
        /// <param name="typology">The source typology to clone.</param>
        protected Typology(Typology<TTypology, TTypologyItem>? typology)
            : base(typology)
        {
            if (typology != null)
            {
                typologyItem = Core.Query.Clone(typology.typologyItem);

                references = [.. typology.references];

                foreach (KeyValuePair<int, TTypology> keyValuePair in typology.subTypologies)
                {
                    if (Core.Query.Clone(keyValuePair.Value) is not TTypology typology_SubTypology)
                    {
                        continue;
                    }

                    subTypologies[keyValuePair.Key] = typology_SubTypology;
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Typology{TTypology, TTypologyItem}"/> class from a
        /// JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing typology data.</param>
        protected Typology(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets or sets the description of the typology, held by its typology item.
        /// <para>The setter creates an empty <typeparamref name="TTypologyItem"/> when the typology has
        /// none.</para>
        /// </summary>
        [JsonIgnore]
        public string? Description
        {
            get
            {
                return typologyItem?.Description;
            }

            set
            {
                typologyItem ??= new TTypologyItem();

                typologyItem.Description = value;
            }
        }

        /// <summary>
        /// Gets the indexes the sub-typologies of this typology are filed under.
        /// <para>An index is the filing key of <see cref="this[int]"/> and may differ from the index the
        /// sub-typology reports through its own path - see <see cref="SubTypologies"/>. A new list is built
        /// on every call.</para>
        /// </summary>
        [JsonIgnore]
        public List<int> Indexes
        {
            get
            {
                return [.. subTypologies.Keys];
            }
        }

        /// <summary>
        /// Gets or sets the name of the typology, held by its typology item.
        /// <para>The setter creates an empty <typeparamref name="TTypologyItem"/> when the typology has
        /// none.</para>
        /// </summary>
        [JsonIgnore]
        public string? Name
        {
            get
            {
                return typologyItem?.Name;
            }

            set
            {
                typologyItem ??= new TTypologyItem();

                typologyItem.Name = value;
            }
        }

        /// <summary>
        /// Gets the list of references associated with this typology.
        /// <para>A new list is built on every call, so adding to it does not affect the typology - use
        /// <see cref="AddReference(string)"/> for that.</para>
        /// </summary>
        [JsonIgnore]
        public List<string> References
        {
            get
            {
                return [.. references];
            }
        }

        /// <summary>
        /// Gets or sets the list of sub-typologies associated with this typology.
        /// <para>Each sub-typology is stored under the last index of its own path. A sub-typology
        /// carrying no path, or one whose index is already taken, is filed under the next free
        /// index rather than being discarded, so the assigned key may differ from the path the
        /// sub-typology reports.</para>
        /// <para>The getter builds a new list on every call, but the sub-typologies in it are the
        /// instances this typology holds rather than clones of them.</para>
        /// <para>The setter is protected, not private, on purpose: deserialization reflects the property
        /// through the concrete type, and reflection does not surface a private accessor declared on a base
        /// class, so a private setter here would leave every deserialized tree empty.</para>
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(SubTypologies))]
        public List<TTypology>? SubTypologies
        {
            get
            {
                return [.. subTypologies.Values];
            }

            protected set
            {
                subTypologies.Clear();

                if (value is null)
                {
                    return;
                }

                foreach (TTypology typology in value)
                {
                    if (typology is null)
                    {
                        continue;
                    }

                    int index = typology.typologyItem?.TypologyPath?.Index ?? -1;

                    if (index < 0 || subTypologies.ContainsKey(index))
                    {
                        index = subTypologies.Count == 0 ? 0 : subTypologies.Keys.Max() + 1;
                    }

                    subTypologies[index] = typology;
                }
            }
        }

        /// <summary>
        /// Gets the typology item of this typology, or null when it has none.
        /// <para>The instance this typology holds is returned, not a clone of it - a derived typology reads
        /// the fields of its own item through it.</para>
        /// </summary>
        [JsonIgnore]
        public TTypologyItem? TypologyItem
        {
            get
            {
                return typologyItem;
            }
        }

        /// <summary>
        /// Gets the path of this typology, held by its typology item.
        /// </summary>
        [JsonIgnore]
        public TypologyPath? TypologyPath
        {
            get
            {
                return typologyItem?.TypologyPath;
            }
        }

        /// <summary>
        /// Gets or sets the sub-typology filed under the specified index.
        /// <para>The index is this typology's filing key, which may differ from the index the sub-typology
        /// reports through its own path - see <see cref="SubTypologies"/>. The getter returns null when
        /// nothing is filed under the index; assigning null removes the entry.</para>
        /// </summary>
        /// <param name="index">The index the sub-typology is filed under.</param>
        /// <returns>The sub-typology filed under the index, or null when there is none.</returns>
        public TTypology? this[int index]
        {
            get
            {
                if (!subTypologies.TryGetValue(index, out TTypology? result))
                {
                    return null;
                }

                return result;
            }

            set
            {
                if (value is null)
                {
                    subTypologies.Remove(index);
                    return;
                }

                subTypologies[index] = value;
            }
        }

        /// <summary>
        /// Adds a reference to the typology.
        /// </summary>
        /// <param name="reference">The reference string to add.</param>
        /// <returns>True if the reference was added; otherwise, false (already present or null).</returns>
        public bool AddReference(string? reference)
        {
            if (reference == null)
            {
                return false;
            }

            return references.Add(reference);
        }

        /// <summary>
        /// Determines whether the typology carries a specific reference.
        /// <para>This tests the reference set directly. Reading <see cref="References"/> and searching the
        /// returned list costs a copy and a linear scan instead, which matters on a typology holding many
        /// references. To search the nested typologies as well use the <c>Query.Contains</c> extension of the
        /// concrete type - <see cref="Query.Contains(Typology, string, bool)"/> for <see cref="Typology"/>.</para>
        /// </summary>
        /// <param name="reference">The reference string to search for.</param>
        /// <returns>True if the typology carries the reference; otherwise, false (absent or null).</returns>
        public bool ContainsReference(string? reference)
        {
            if (reference == null)
            {
                return false;
            }

            return references.Contains(reference);
        }

        /// <summary>
        /// Removes a reference from the typology.
        /// </summary>
        /// <param name="reference">The reference string to remove.</param>
        /// <returns>True if the reference was removed; otherwise, false (absent or null).</returns>
        public bool RemoveReference(string? reference)
        {
            if (reference == null)
            {
                return false;
            }

            return references.Remove(reference);
        }

        /// <summary>
        /// Compares the current typology with another typology.
        /// <para>The typology item is the primary ordering, compared through the virtual
        /// <see cref="TypologyItem.CompareTo(TypologyItem)"/>, so an item type overriding it is honoured
        /// whatever item type the typology declares. Typologies sharing an item are ordered by
        /// their reference sets and then, recursively, by their sub-typologies, so this method returns zero
        /// exactly when <see cref="Equals(TTypology)"/> returns true. Like equality it therefore costs
        /// O(n) over the sub-typology tree whenever the items tie.</para>
        /// </summary>
        /// <param name="typology">The typology to compare against.</param>
        /// <returns>A signed integer that indicates the relative order of the objects being compared.</returns>
        public int CompareTo(TTypology typology)
        {
            if (typology is null)
            {
                return 1; // non-null > null
            }

            int compare;

            if (typologyItem is null)
            {
                compare = typology.typologyItem is null ? 0 : -1;
            }
            else if (typology.typologyItem is null)
            {
                compare = 1; // non-null > null
            }
            else
            {
                compare = typologyItem.CompareTo(typology.typologyItem);
            }

            if (compare != 0)
            {
                return compare;
            }

            compare = references.Count.CompareTo(typology.references.Count);
            if (compare != 0)
            {
                return compare;
            }

            List<string> references_This = [.. references];
            List<string> references_Other = [.. typology.references];

            references_This.Sort(StringComparer.Ordinal);
            references_Other.Sort(StringComparer.Ordinal);

            for (int i = 0; i < references_This.Count; i++)
            {
                compare = string.CompareOrdinal(references_This[i], references_Other[i]);
                if (compare != 0)
                {
                    return compare;
                }
            }

            compare = subTypologies.Count.CompareTo(typology.subTypologies.Count);
            if (compare != 0)
            {
                return compare;
            }

            List<int> indexes_This = [.. subTypologies.Keys];
            List<int> indexes_Other = [.. typology.subTypologies.Keys];

            indexes_This.Sort();
            indexes_Other.Sort();

            for (int i = 0; i < indexes_This.Count; i++)
            {
                compare = indexes_This[i].CompareTo(indexes_Other[i]);
                if (compare != 0)
                {
                    return compare;
                }

                compare = subTypologies[indexes_This[i]].CompareTo(typology.subTypologies[indexes_Other[i]]);
                if (compare != 0)
                {
                    return compare;
                }
            }

            return 0;
        }

        /// <summary>
        /// Determines whether the specified typology is value-equal to the current typology.
        /// <para>Equality is deep: the typology item, the reference set and the whole sub-typology tree,
        /// sub-typologies matched by the index they are filed under. The items are compared through the
        /// virtual <see cref="TypologyItem.Equals(TypologyItem)"/>, so an item type overriding it is honoured
        /// whatever item type the typology declares. The call costs O(n) over the sub-typology tree.</para>
        /// </summary>
        /// <param name="typology">The typology to compare with the current instance.</param>
        /// <returns>True if the typologies are value-equal; otherwise, false.</returns>
        public bool Equals(TTypology? typology)
        {
            if (typology is null)
            {
                return false;
            }

            if (ReferenceEquals(this, typology))
            {
                return true;
            }

            if (typologyItem != typology.typologyItem)
            {
                return false;
            }

            if (!references.SetEquals(typology.references))
            {
                return false;
            }

            if (subTypologies.Count != typology.subTypologies.Count)
            {
                return false;
            }

            foreach (KeyValuePair<int, TTypology> keyValuePair in subTypologies)
            {
                if (!typology.subTypologies.TryGetValue(keyValuePair.Key, out TTypology? typology_SubTypology) || !keyValuePair.Value.Equals(typology_SubTypology))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Determines whether the specified object is value-equal to the current typology.
        /// </summary>
        /// <param name="object">The object to compare with the current instance.</param>
        /// <returns>True if the object is a <typeparamref name="TTypology"/> of equal value; otherwise, false.</returns>
        public override bool Equals(object? @object)
        {
            return @object is TTypology typology && Equals(typology);
        }

        /// <summary>
        /// Returns a hash code for the current typology based on its item, its references and its
        /// sub-typology tree.
        /// <para>The references and the sub-typologies are combined order-independently, matching the
        /// unordered semantics of equality. The whole instance is mutable, so the hash follows every
        /// change made through the setters, <see cref="AddReference(string)"/>,
        /// <see cref="RemoveReference(string)"/> and the <c>Modify</c> extensions - a typology must not be
        /// mutated while it is held as a key of a dictionary or a set. Computing it costs O(n) over the
        /// sub-typology tree.</para>
        /// </summary>
        /// <returns>A 32-bit signed integer hash code.</returns>
        public override int GetHashCode()
        {
            unchecked // allow arithmetic overflow
            {
                int hash_References = 0;
                foreach (string reference in references)
                {
                    hash_References ^= reference.GetHashCode();
                }

                int hash_SubTypologies = 0;
                foreach (KeyValuePair<int, TTypology> keyValuePair in subTypologies)
                {
                    hash_SubTypologies ^= (keyValuePair.Key * 397) ^ keyValuePair.Value.GetHashCode();
                }

                int hash = 17;
                hash = hash * 31 + (typologyItem?.GetHashCode() ?? 0);
                hash = hash * 31 + hash_References;
                hash = hash * 31 + hash_SubTypologies;

                return hash;
            }
        }

        /// <summary>
        /// Determines whether two typologies are value-equal (null-safe).
        /// </summary>
        /// <param name="typology_1">The first typology, or null.</param>
        /// <param name="typology_2">The second typology, or null.</param>
        /// <returns>True if both are null or value-equal; otherwise, false.</returns>
        public static bool operator ==(Typology<TTypology, TTypologyItem>? typology_1, Typology<TTypology, TTypologyItem>? typology_2)
        {
            if (typology_1 is null)
            {
                return typology_2 is null;
            }

            return typology_1.Equals(typology_2 as TTypology);
        }

        /// <summary>
        /// Determines whether two typologies are not value-equal (null-safe).
        /// </summary>
        /// <param name="typology_1">The first typology, or null.</param>
        /// <param name="typology_2">The second typology, or null.</param>
        /// <returns>True if the typologies differ in value; otherwise, false.</returns>
        public static bool operator !=(Typology<TTypology, TTypologyItem>? typology_1, Typology<TTypology, TTypologyItem>? typology_2)
        {
            return !(typology_1 == typology_2);
        }

        /// <summary>Returns a string representation of the current typology.</summary>
        /// <returns>The string form of the typology item, or the base object string when there is none.</returns>
        public override string ToString()
        {
            return typologyItem?.ToString() ?? base.ToString();
        }
    }

    /// <summary>
    /// Represents a typology node holding a plain <see cref="TypologyItem"/>. All behaviour is inherited from
    /// <see cref="Typology{TTypology, TTypologyItem}"/>; this type only exposes the constructors.
    /// </summary>
    public class Typology : Typology<Typology, TypologyItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Typology"/> class by cloning an existing typology.
        /// </summary>
        /// <param name="typology">The source typology object to clone.</param>
        public Typology(Typology? typology)
            : base(typology)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Typology"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing typology data.</param>
        public Typology(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Typology"/> class with a specified typology item.
        /// <para>Use <see cref="Create.Typology(TypologyItem, IEnumerable{Typology})"/> to build an instance
        /// that also carries sub-typologies: filing each one resolves an index against the indexes already
        /// taken, which does not belong in a constructor.</para>
        /// </summary>
        /// <param name="typologyItem">The typology item to assign; it is cloned.</param>
        public Typology(TypologyItem? typologyItem)
            : base(typologyItem)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Typology"/> class with a specified name and description.
        /// </summary>
        /// <param name="name">The name of the typology.</param>
        /// <param name="description">The description of the typology.</param>
        public Typology(string? name, string? description)
            : base(new TypologyItem(null, name, description))
        {
        }
    }
}
