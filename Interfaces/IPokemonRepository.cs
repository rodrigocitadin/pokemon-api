using PokemonApi.Models;

namespace PokemonApi.Interfaces;

interface IPokemonRepository
{
    ICollection<Pokemon> GetPokemons();
    ICollection<Pokemon> GetPokemons(string name);
    Pokemon? GetPokemon(int id);
    decimal GetPokemonRating(int pokemonId);
}
