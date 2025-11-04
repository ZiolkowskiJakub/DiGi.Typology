using DiGi.Typology.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Typology.Classes
{
    public class TypologyFile : Core.IO.File.Classes.ValueFile<Typology>, ITypologyObject
    {
        public TypologyFile(TypologyFile? typologyFile)
            : base(typologyFile)
        {

        }

        public TypologyFile(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        public TypologyFile(string path)
            : base(path)
        {

        }

    }
}
