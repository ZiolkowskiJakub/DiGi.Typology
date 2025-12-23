using DiGi.Core.Interfaces;
using DiGi.Typology.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Typology.Classes
{
    public class TypologyItem : Core.Classes.SerializableObject, ITypologyObject, INamedObject, IDescribableObject, IComparable<TypologyItem>
    {
        [JsonInclude, JsonPropertyName("TypologyPath")]
        private readonly TypologyPath? typologyPath;

        [JsonInclude, JsonPropertyName("Description")]
        private string? description;

        [JsonInclude, JsonPropertyName("Name")]
        private string? name;

        public TypologyItem()
        {
        }

        public TypologyItem(IEnumerable<int>? values, string? name, string? description)
        {
            typologyPath = values == null ? null : new TypologyPath(values);
            this.description = description;
            this.name = name;
        }

        public TypologyItem(IEnumerable<int>? values, string? name)
        {
            typologyPath = values == null ? null : new TypologyPath(values);
            this.name = name;
        }

        public TypologyItem(TypologyPath? typologyPath, string? name, string? description)
        {
            this.typologyPath = Core.Query.Clone(typologyPath);
            this.description = description;
            this.name = name;
        }

        public TypologyItem(TypologyPath? typologyPath, string? name)
        {
            this.typologyPath = Core.Query.Clone(typologyPath);
            this.name = name;
        }

        public TypologyItem(TypologyPath? typologyPath, TypologyItem typologyItem)
        {
            this.typologyPath = Core.Query.Clone(typologyPath);
            name = typologyItem.name;
            description = typologyItem.description;
        }

        public TypologyItem(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

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

        [JsonIgnore]
        public TypologyPath? TypologyPath
        {
            get
            {
                return typologyPath;
            }
        }

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

        public override string ToString()
        {
            string? path = typologyPath?.ToString();
            string name = this.name ?? "???";

            return string.IsNullOrWhiteSpace(path) ? name : string.Format("[{0}] {1}", path, name);
        }
    }
}