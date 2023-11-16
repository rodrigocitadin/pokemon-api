using PokemonApi.Models;

namespace PokemonApi.Interfaces;

public interface IPokemonRepository
{
    ICollection<Pokemon> GetPokemons();
    Pokemon? GetPokemon(int id);
    Pokemon GetPokemon(string name);
    decimal GetPokemonRating(int PokemonId);
    bool PokemonExists(int PokemonId);
}
