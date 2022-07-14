using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Models
{

    public class Stats
    {
        [JsonProperty("base_stat")]
        public string BaseStat { get; set; }

        [JsonProperty("effort")]
        public string Effort { get; set; }

        [JsonProperty("stat")]
        public Item Stat;

        public Stats(string baseStat, string effort, Item stat)
        {
            BaseStat = baseStat;
            Effort = effort;
            Stat = stat;
        }
    }
}
