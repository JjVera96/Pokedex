using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Models
{
    public class Moves
    {
        [JsonProperty("move")]
        public Item Move;

        public Moves(Item move)
        {
            Move = move;
        }
    }
}
