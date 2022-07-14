using Newtonsoft.Json;
using Pokedex.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Models
{
    public class Item
    {
        public Item(string name, string uRL)
        {
            Name = name;
            URL = uRL;
        }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        public string GetName()
        {
            return FormatString.Capitalize(Name);
        }
    }
}
