using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Models
{
    public class Chain
    {
        public Chain(bool isBaby, Item species, Chain[] evolvesTo)
        {
            IsBaby = isBaby;
            Species = species;
            EvolvesTo = evolvesTo;
        }

        [JsonProperty("is_baby")]
        public bool IsBaby { get; set; }

        [JsonProperty("species")]
        public Item Species { get; set; }

        [JsonProperty("evolves_to")]
        public Chain[] EvolvesTo { get; set; }

    }
}
