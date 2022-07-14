using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Serializers
{
    public static class EvolutionChainSerializer
    {
        public static Models.EvolutionChain? ToJson(string json) => JsonConvert.DeserializeObject<Models.EvolutionChain>(json, Utils.Converter.Settings);
        public static string ToString(this Models.EvolutionChain self) => JsonConvert.SerializeObject(self);
    }
}
