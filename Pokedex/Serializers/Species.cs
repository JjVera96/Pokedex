using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Serializers
{
    public static class SpeciesSerializer
    {
        public static Models.Species? ToJson(string json) => JsonConvert.DeserializeObject<Models.Species>(json, Utils.Converter.Settings);
        public static string ToString(this Models.Species self) => JsonConvert.SerializeObject(self);
    }
}
