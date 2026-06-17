using DiGi.Typology.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Typology.Classes
{
    /// <summary>Represents a typology file containing typology data.</summary>
    public class TypologyFile : Core.IO.File.Classes.ValueFile<Typology>, ITypologyObject
    {
        /// <summary>Initializes a new instance of the <see cref="TypologyFile"/> class based on an existing <see cref="TypologyFile"/> instance.</summary>
        /// <param name="typologyFile">The source typology file to copy from.</param>
        public TypologyFile(TypologyFile? typologyFile)
            : base(typologyFile)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="TypologyFile"/> class using a JSON object.</summary>
        /// <param name="jsonObject">The JSON object containing typology data.</param>
        public TypologyFile(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="TypologyFile"/> class from the specified file path.</summary>
        /// <param name="path">The path to the typology file.</param>
        public TypologyFile(string path)
            : base(path)
        {
        }
    }
}