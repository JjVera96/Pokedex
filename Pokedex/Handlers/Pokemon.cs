using Pokedex.Serializers;
using Pokedex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Handlers
{
    public class PokemonHandler
    {
        public Pokemon? pokemon;
        public Pokemon? evolutionPokemon;
        public EvolutionChain? evolutionChain;
        readonly HttpClient Client = new ();
        readonly string URL = "https://pokeapi.co/api/v2/";

        public async Task GetPokemon(string search)
        {
            pokemon = null;
            evolutionChain = null;
            try
            {
                string response = await Client.GetStringAsync($"{URL}pokemon/{search}");
                pokemon = PokemonSerializer.ToJson(response);
            }
            catch (HttpRequestException) { 
            }
        }

        public string PokemonToString()
        {
            if (pokemon != null) return PokemonSerializer.ToString(pokemon);
            return "";
        }

        public async Task GetEvolutionChain()
        {
            if (pokemon != null)
            {
                try
                {
                    string response = await Client.GetStringAsync(pokemon.Species.URL);
                    Species? species = SpeciesSerializer.ToJson(response);
                    if (species != null)
                    {
                        try
                        {
                            response = await Client.GetStringAsync(species.EvolutionChain.URL);
                            evolutionChain = EvolutionChainSerializer.ToJson(response);
                        }
                        catch (HttpRequestException){ }
                    }
                }
                catch (HttpRequestException) { }
            }
        }

        public async Task GetEvolutionPokemon(string search)
        {
            evolutionPokemon = null;
            try
            {
                string response = await Client.GetStringAsync($"{URL}pokemon/{search}");
                evolutionPokemon = PokemonSerializer.ToJson(response);
            }
            catch (HttpRequestException)
            {
            }
        }
    }
}
