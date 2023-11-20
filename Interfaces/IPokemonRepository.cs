using PokemonApi.Models;

namespace PokemonApi.Interfaces;

interface IPokemonRepository
{
    ICollection<Pokemon> GetPokemons();
    Pokemon? GetPokemon(int id);
    Pokemon? GetPokemon(string name);
    decimal GetPokemonRating(int pokemonId);
}
