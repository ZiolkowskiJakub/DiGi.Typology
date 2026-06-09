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
    public class TypologyItem : Core.Classes.SerializableObject, ITypologyObject, INamedObject, IDescribableObject, IComparable<TypologyItem>
    {
        [JsonInclude, JsonPropertyName("TypologyPath")]
        private readonly TypologyPath? typologyPath;

        [JsonInclude, JsonPropertyName("Description")]
        private string? description;

        [JsonInclude, JsonPropertyName("Name")]
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
        /// </summary>
        /// <param name="typologyItem">The item to compare with this instance.</param>
        /// <returns>A value indicating the relative order of the objects being compared.</returns>
        public int CompareTo(TypologyItem typologyItem)
        {
            if (typologyPath == null)
            {
                return int.MinValue;
            }

            if (typologyItem?.typologyPath == null)
            {
                return 1; // non-null > null
            }

            return typologyPath.CompareTo(typologyItem.typologyPath);
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
