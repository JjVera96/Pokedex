using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Models
{
    public class Sprite
    {
        public Sprite(string backDefault, string frontDefault)
        {
            BackDefault = backDefault;
            FrontDefault = frontDefault;
        }

        [JsonProperty("back_default")]
        public string BackDefault { get; set; }

        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }
    }
}
