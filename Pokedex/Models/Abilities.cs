using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Models
{

    public class Abilities
    {
        [JsonProperty("is_hidden")]
        public string IsHidden { get; set; }

        [JsonProperty("ability")]
        public Item Ability;

        public Abilities(string isHidden, Item ability)
        {
            IsHidden = isHidden;
            Ability = ability;
        }
    }
}
