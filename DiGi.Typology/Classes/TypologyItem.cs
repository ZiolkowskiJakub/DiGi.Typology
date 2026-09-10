using DiGi.Core.Interfaces;
using DiGi.Typology.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Typology.Classes
{
    /// <summary>
    /// Represents an item within a typology system, providing identification via a path and descriptive metadata.
    /// </summary>
    public class TypologyItem : Core.Classes.SerializableObject, ITypologySerializableObject, INamedObject, IDescribableObject, IComparable<TypologyItem>, IEquatable<TypologyItem>
    {
        [JsonInclude, JsonPropertyName(nameof(TypologyPath))]
        private readonly TypologyPath? typologyPath;

        [JsonInclude, JsonPropertyName(nameof(Description))]
        private string? description;

        [JsonInclude, JsonPropertyName(nameof(Name))]
        private string? name;

        /// <summary>
        /// Initializes a new instance of the <see cref="TypologyItem"/> class.
        /// </summary>
        public TypologyItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypologyItem"/> class using a collection of path values, a name, and a description.
        /// </summary>
        /// <param name="values">The sequence of integers defining the typology path.</param>
        /// <param name="name">The name of the item.</param>
        /// <param name="description">The description of the item.</param>
        public TypologyItem(IEnumerable<int>? values, string? name, string? description)
        {
            typologyPath = values == null ? null : new TypologyPath(values);
            this.description = description;
            this.name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypologyItem"/> class using a collection of path values and a name.
        /// </summary>
        /// <param name="values">The sequence of integers defining the typology path.</param>
        /// <param name="name">The name of the item.</param>
        public TypologyItem(IEnumerable<int>? values, string? name)
        {
            typologyPath = values == null ? null : new TypologyPath(values);
            this.name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypologyItem"/> class using a typology path, a name, and a description.
        /// </summary>
        /// <param name="typologyPath">The path associated with this item.</param>
        /// <param name="name">The name of the item.</param>
        /// <param name="description">The description of the item.</param>
        public TypologyItem(TypologyPath? typologyPath, string? name, string? description)
        {
            this.typologyPath = Core.Query.Clone(typologyPath);
            this.description = description;
            this.name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypologyItem"/> class using a typology path and a name.
        /// </summary>
        /// <param name="typologyPath">The path associated with this item.</param>
        /// <param name="name">The name of the item.</param>
        public TypologyItem(TypologyPath? typologyPath, string? name)
        {
            this.typologyPath = Core.Query.Clone(typologyPath);
            this.name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypologyItem"/> class using a specific typology path and metadata from another item.
        /// </summary>
        /// <param name="typologyPath">The path to assign to this item.</param>
        /// <param name="typologyItem">The source item to copy the name and description from.</param>
        public TypologyItem(TypologyPath? typologyPath, TypologyItem typologyItem)
        {
            this.typologyPath = Core.Query.Clone(typologyPath);
            name = typologyItem.name;
            description = typologyItem.description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypologyItem"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing item data.</param>
        public TypologyItem(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypologyItem"/> class by cloning an existing item.
        /// </summary>
        /// <param name="typologyItem">The source item to clone.</param>
        public TypologyItem(TypologyItem? typologyItem)
            : base(typologyItem)
        {
            if (typologyItem is not null)
            {
                typologyPath = Core.Query.Clone(typologyItem.typologyPath);
                description = typologyItem.description;
                name = typologyItem.name;
            }
        }

        /// <summary>
        /// Gets or sets the description of the typology item.
        /// </summary>
        [JsonIgnore]
        public string? Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        /// <summary>
        /// Gets or sets the name of the typology item.
        /// </summary>
        [JsonIgnore]
        public string? Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        /// <summary>
        /// Gets the typology path associated with this item.
        /// </summary>
        [JsonIgnore]
        public TypologyPath? TypologyPath
        {
            get
            {
                return typologyPath;
            }
        }

        /// <summary>
        /// Compares the current instance with another <see cref="TypologyItem"/> based on their paths.
        /// <para>The path is the primary ordering; items sharing a path are ordered by name and then by
        /// description, compared ordinally, so this method returns zero exactly when
        /// <see cref="Equals(TypologyItem)"/> returns true.</para>
        /// </summary>
        /// <param name="typologyItem">The item to compare with this instance.</param>
        /// <returns>A value indicating the relative order of the objects being compared.</returns>
        public int CompareTo(TypologyItem typologyItem)
        {
            if (typologyItem is null)
            {
                return 1; // non-null > null
            }

            int compare;

            if (typologyPath is null)
            {
                compare = typologyItem.typologyPath is null ? 0 : -1;
            }
            else if (typologyItem.typologyPath is null)
            {
                compare = 1; // non-null > null
            }
            else
            {
                compare = typologyPath.CompareTo(typologyItem.typologyPath);
            }

            if (compare != 0)
            {
                return compare;
            }

            compare = string.CompareOrdinal(name, typologyItem.name);
            if (compare != 0)
            {
                return compare;
            }

            return string.CompareOrdinal(description, typologyItem.description);
        }

        /// <summary>
        /// Determines whether the specified item is value-equal to the current item.
        /// </summary>
        /// <param name="typologyItem">The item to compare with the current instance.</param>
        /// <returns>True if the path, the name and the description are all equal; otherwise, false.</returns>
        public bool Equals(TypologyItem? typologyItem)
        {
            if (typologyItem is null)
            {
                return false;
            }

            if (ReferenceEquals(this, typologyItem))
            {
                return true;
            }

            if (typologyPath != typologyItem.typologyPath)
            {
                return false;
            }

            if (!string.Equals(name, typologyItem.name, StringComparison.Ordinal))
            {
                return false;
            }

            return string.Equals(description, typologyItem.description, StringComparison.Ordinal);
        }

        /// <summary>
        /// Determines whether the specified object is value-equal to the current item.
        /// </summary>
        /// <param name="object">The object to compare with the current instance.</param>
        /// <returns>True if the object is a <see cref="TypologyItem"/> of equal value; otherwise, false.</returns>
        public override bool Equals(object? @object)
        {
            return @object is TypologyItem typologyItem && Equals(typologyItem);
        }

        /// <summary>
        /// Returns a hash code for the current item based on its path, name and description.
        /// <para>The name and the description are mutable, so the hash follows them - an item must not be
        /// mutated while it is held as a key of a dictionary or a set.</para>
        /// </summary>
        /// <returns>A 32-bit signed integer hash code.</returns>
        public override int GetHashCode()
        {
            unchecked // allow arithmetic overflow
            {
                int hash = 17;
                hash = hash * 31 + (typologyPath?.GetHashCode() ?? 0);
                hash = hash * 31 + (name?.GetHashCode() ?? 0);
                hash = hash * 31 + (description?.GetHashCode() ?? 0);

                return hash;
            }
        }

        /// <summary>
        /// Determines whether two items are value-equal (null-safe).
        /// </summary>
        /// <param name="typologyItem_1">The first item, or null.</param>
        /// <param name="typologyItem_2">The second item, or null.</param>
        /// <returns>True if both are null or value-equal; otherwise, false.</returns>
        public static bool operator ==(TypologyItem? typologyItem_1, TypologyItem? typologyItem_2)
        {
            if (typologyItem_1 is null)
            {
                return typologyItem_2 is null;
            }

            return typologyItem_1.Equals(typologyItem_2);
        }

        /// <summary>
        /// Determines whether two items are not value-equal (null-safe).
        /// </summary>
        /// <param name="typologyItem_1">The first item, or null.</param>
        /// <param name="typologyItem_2">The second item, or null.</param>
        /// <returns>True if the items differ in value; otherwise, false.</returns>
        public static bool operator !=(TypologyItem? typologyItem_1, TypologyItem? typologyItem_2)
        {
            return !(typologyItem_1 == typologyItem_2);
        }

        /// <summary>
        /// Returns a string representation of the current item, typically in the format "[path] name".
        /// </summary>
        /// <returns>A string representing the typology item.</returns>
        public override string ToString()
        {
            string? path = typologyPath?.ToString();
            string name = this.name ?? "???";

            return string.IsNullOrWhiteSpace(path) ? name : string.Format("[{0}] {1}", path, name);
        }
    }
}