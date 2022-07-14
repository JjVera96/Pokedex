using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Models
{
    public class EvolutionChain
    {
        public EvolutionChain(int id, Chain chain)
        {
            Id = id;
            Chain = chain;
        }

        [JsonProperty("id")]
        public int Id { get; set; }
        
        [JsonProperty("chain")]
        public Chain Chain { get; set; }

    }
}
