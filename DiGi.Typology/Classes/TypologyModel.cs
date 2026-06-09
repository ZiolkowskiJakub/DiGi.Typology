using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Typology.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Typology.Classes
{
    /// <summary>
    /// Represents a model for typology data, inheriting from GuidModel and implementing ITypologyObject and INamedObject.
    /// </summary>
    public class TypologyModel : GuidModel, ITypologyObject, INamedObject
    {
        [JsonInclude, JsonPropertyName(nameof(Name))]
        private string? name = null;

        [JsonInclude, JsonPropertyName(nameof(Typology))]
        private Typology? typology = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TypologyModel"/> class.
        /// </summary>
        public TypologyModel()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypologyModel"/> class with specified GUID, name, and typology.
        /// </summary>
        /// <param name="guid">The unique identifier for the model.</param>
        /// <param name="name">The name of the typology model.</param>
        /// <param name="typology">The typology associated with the model.</param>
        public TypologyModel(Guid guid, string? name, Typology? typology)
            : base(guid)
        {
            this.name = name;
            this.typology = typology;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypologyModel"/> class with specified name and typology.
        /// </summary>
        /// <param name="name">The name of the typology model.</param>
        /// <param name="typology">The typology associated with the model.</param>
        public TypologyModel(string? name, Typology? typology)
            : base()
        {
            this.name = name;
            this.typology = typology;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypologyModel"/> class by cloning an existing typology model.
        /// </summary>
        /// <param name="typologyModel">The source typology model to clone.</param>
        public TypologyModel(TypologyModel? typologyModel)
            : base(typologyModel)
        {
            if (typologyModel is not null)
            {
                typology = Core.Query.Clone(typologyModel.typology);
                name = typologyModel.name;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypologyModel"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the model data.</param>
        public TypologyModel(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets or sets the name of the typology model.
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
        /// Gets or sets the typology associated with the model.
        /// </summary>
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
