using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Serializers
{
    public static class PokemonSerializer
    {
        public static Models.Pokemon? ToJson(string json) => JsonConvert.DeserializeObject<Models.Pokemon>(json, Utils.Converter.Settings);
        public static string ToString(this Models.Pokemon self) => JsonConvert.SerializeObject(self);
    }
}
