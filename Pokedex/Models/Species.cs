using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Models
{
    public class Species
    {
        public Species(Item evolutionChain)
        {
            EvolutionChain = evolutionChain;
        }

        [JsonProperty("evolution_chain")]
        public Item EvolutionChain { get; set; }
    }
}
