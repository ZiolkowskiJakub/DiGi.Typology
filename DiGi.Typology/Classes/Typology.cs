using DiGi.Core.Interfaces;
using DiGi.Typology.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Typology.Classes
{
    public class Typology : Core.Classes.SerializableObject, ITypologyObject, INamedObject, IDescribableObject
    {
        [JsonInclude, JsonPropertyName("References")]
        private readonly HashSet<string> references = [];

        [JsonIgnore]
        private readonly Dictionary<int, Typology> subTypologies = [];

        [JsonInclude, JsonPropertyName("TypologyItem")]
        private TypologyItem? typologyItem;
        
        public Typology(Typology? typology)
            : base(typology)
        {
            if (typology != null)
            {
                typologyItem = Core.Query.Clone(typology.typologyItem);

                references = [.. typology.references];

                SubTypologies = typology.SubTypologies;
            }
        }

        public Typology(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        public Typology(TypologyItem? typologyItem)
        {
            this.typologyItem = Core.Query.Clone(typologyItem);
        }

        public Typology(TypologyItem? typologyItem, IEnumerable<Typology>? subTypologies)
        {
            this.typologyItem = Core.Query.Clone(typologyItem);

            if (subTypologies != null)
            {
                SubTypologies = [.. subTypologies];
            }
        }

        public Typology(string? name, string? description)
        {
            typologyItem = new TypologyItem(null, name, description);
        }

        public string? Description
        {
            get
            {
                return typologyItem?.Description;
            }

            set
            {
                typologyItem ??= new TypologyItem();

                typologyItem.Description = value;
            }
        }

        public string? Name
        {
            get
            {
                return typologyItem?.Name;
            }

            set
            {
                typologyItem ??= new TypologyItem();

                typologyItem.Name = value;
            }
        }

        [JsonIgnore]
        public List<string> References
        {
            get
            {
                return [.. references];
            }
        }

        [JsonInclude, JsonPropertyName("SubTypologies")]
        public List<Typology>? SubTypologies
        {
            get
            {
                return [.. subTypologies.Values];
            }

            private set
            {
                subTypologies?.Clear();
                if(value != null)
                {
                    foreach (Typology typology in value)
                    {
                        if(typology?.typologyItem?.TypologyPath?.Index is int index)
                        {
                            subTypologies![index] = typology;
                        }
                    }
                }

            }
        }

        public bool AddReference(string? reference)
        {
            if (reference == null)
            {
                return false;
            }

            return references.Add(reference);
        }

        public Typology? GetTypology(TypologyPath? typologyPath)
        {
            if (typologyPath is null)
            {
                return null;
            }

            if (typologyPath.ParentCount <= 0)
            {
                if (!subTypologies.TryGetValue(typologyPath.Index, out Typology? result))
                {
                    result = null;
                }

                return result;
            }

            if (typologyPath.GetParent(0) is not TypologyPath typologyPath_Parent)
            {
                return null;
            }

            if (!subTypologies.TryGetValue(typologyPath_Parent.Index, out Typology? typology_Parent))
            {
                return null;
            }

            return typology_Parent.GetTypology(typologyPath.GetTypologyPath(1, typologyPath.Count - 1));
        }

        public Typology? GetTypology(IEnumerable<int>? values)
        {
            if(values is null)
            {
                return null;
            }

            return GetTypology(new TypologyPath(values));
        }

        public override string ToString()
        {
            return typologyItem?.ToString() ?? base.ToString();
        }

        public bool TryGetLastIndex(out int index)
        {
            index = -1;
            if (subTypologies is null || subTypologies.Count == 0)
            {
                return false;
            }

            index = subTypologies.Keys.Max();
            return true;
        }

        public Typology? Update(TypologyItem? typologyItem)
        {
            if(typologyItem is null)
            {
                return null;
            }

            if(typologyItem.TypologyPath is not TypologyPath typologyPath)
            {
                if(!TryGetLastIndex(out int index))
                {
                    index = 1;
                }

                typologyPath = new TypologyPath([index]);
            }

            Typology? result;

            if (typologyPath.Parent is not TypologyPath typologyPath_Parent)
            {
                typologyPath_Parent = (this.typologyItem?.TypologyPath + typologyPath)!;

                result = GetTypology(typologyPath_Parent);
                if(result is null)
                {
                    result = new Typology(new TypologyItem(typologyPath_Parent, typologyItem));
                }
                else
                {
                    result.Name = typologyItem.Name;
                    result.Description = typologyItem.Description;
                }

                subTypologies[typologyPath.Index] = result;
                return result;
            }

            Typology? typology_Parent = GetTypology(typologyPath_Parent);
            if(typology_Parent is null)
            {
                typology_Parent = new Typology(new TypologyItem(this.typologyItem?.TypologyPath + typologyPath_Parent, null, null));
                subTypologies[typologyPath_Parent.Index] = typology_Parent;
            }

            return typology_Parent.Update(new TypologyItem(typologyPath.GetTypologyPath(1, typologyPath.Count - 1), typologyItem));
        }

        public Typology? Update(IEnumerable<int>? values, string? name, string? description)
        {
            return Update(new TypologyItem(new TypologyPath(values), name, description));
        }

        public Typology? Update(string? name, string? description)
        {
            return Update(new TypologyItem(null, name, description));
        }
    }
}
