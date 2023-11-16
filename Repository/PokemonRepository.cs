using PokemonApi.Data;
using PokemonApi.Interfaces;
using PokemonApi.Models;

namespace PokemonApi.Repository;

public class PokemonRepository : IPokemonRepository
{
    private readonly DataContext _context;

    public PokemonRepository(DataContext context)
    {
        _context = context;
    }

    public ICollection<Pokemon> GetPokemons() => _context
        .Pokemons
        .OrderBy(p => p.Id)
        .ToList();

    public Pokemon? GetPokemon(int id) => _context
        .Pokemons
        .First(p => p.Id == id);

    public Pokemon? GetPokemon(string name) => _context
        .Pokemons
        .Where(p => p.Name == name)
        .FirstOrDefault();

    public decimal GetPokemonRating(int pokemonId) => _context
        .Reviews
        .Where(p => p.Id == pokemonId)
        .Average(r => r.Rating);
}
