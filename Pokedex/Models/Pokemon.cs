using Newtonsoft.Json;
using Pokedex.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Models
{
    public class Pokemon
    {
        public Pokemon(int pokemonID, string name, string height, string weight, string baseExperience, Sprite sprites, Types[] types, Moves[] moves, Stats[] stats, Abilities[] abilities, Item species)
        {
            PokemonID = pokemonID;
            Name = name;
            Height = height;
            Weight = weight;
            BaseExperience = baseExperience;
            Sprites = sprites;
            Types = types;
            Moves = moves;
            Stats = stats;
            Abilities = abilities;
            Species = species;
        }

        [JsonProperty("id")]
        public int PokemonID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("weight")]
        public string Weight { get; set; }

        [JsonProperty("base_experience")]
        public string BaseExperience { get; set; }

        [JsonProperty("sprites")]
        public Sprite Sprites { get; set; }

        [JsonProperty("types")]
        public Types[] Types { get; set; }

        [JsonProperty("moves")]
        public Moves[] Moves { get; set; }

        [JsonProperty("stats")]
        public Stats[] Stats { get; set; }

        [JsonProperty("abilities")]
        public Abilities[] Abilities { get; set; }

        [JsonProperty("species")]
        public Item Species { get; set; }

        public string GetName()
        {
            return FormatString.Capitalize(Name);
        }

        public string GetTypesLabel()
        {
            var GetType = Types.Select(x => x.Type.GetName());
            string types = string.Join(", ", GetType);
            return types;
        }
    }
}
