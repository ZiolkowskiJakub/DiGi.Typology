using DiGi.Core.Interfaces;
using System;

namespace DiGi.Typology.Scripting.Classes
{
    public class TypologyScriptUpdater<TScript> : IUpdater where TScript : DiGi.Scripting.Classes.Script
    {
        protected TScript script;

        public bool Update()
        {
            throw new NotImplementedException();
        }
    }
}
