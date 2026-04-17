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
    public class TypologyModel : GuidModel, ITypologyObject, INamedObject
    {
        [JsonInclude, JsonPropertyName(nameof(Name))]
        private string? name = null;

        [JsonInclude, JsonPropertyName(nameof(Typology))]
        private Typology? typology = null;
        
        public TypologyModel()
            :base()
        {

        }

        public TypologyModel(Guid guid, string? name, Typology? typology)
            : base(guid)
        {
            this.name = name;
            this.typology = typology;
        }

        public TypologyModel(string? name, Typology? typology)
            : base()
        {
            this.name = name;
            this.typology = typology;
        }

        public TypologyModel(TypologyModel? typologyModel)
            : base(typologyModel)
        {
            if(typologyModel is not null)
            {
                typology = Core.Query.Clone(typologyModel.typology);
                name = typologyModel.name;
            }
        }

        public TypologyModel(JsonObject? jsonObject)
            :base(jsonObject)
        {

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
        public Typology? Typology
        {
            get
            {
                return typology;
            }

            set
            {
                typology = value;
            }
        }

    }
}