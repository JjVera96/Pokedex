using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Models
{

    public class Types
    {
        [JsonProperty("type")]
        public Item Type;

        public Types(Item type)
        {
            Type = type;
        }
    }
}
