using System.Collections.Generic;

namespace DiGi.Typology
{
    public static partial class Modify
    {
        public static bool TryUpdateByName(this Classes.Typology? @in, IEnumerable<int>? values, string? name, string? description, out Classes.Typology? @out)
        {
            @out = null;

            if (name is null || @in is null)
            {
                return false;
            }

            if (!@in.TryGetTypologies(name, out List<Classes.Typology>? typologies) || typologies == null || typologies.Count == 0)
            {
                @out = @in.Update(values, name, description);
            }
            else
            {
                @out = typologies[0];
                @out.Description = description;
            }

            if(@out is null)
            {
                return false;
            }

            return true;
        }
    }
}
