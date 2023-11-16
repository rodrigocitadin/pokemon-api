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
        .Where(p => p.Id == id)
        .FirstOrDefault();

    public Pokemon GetPokemon(string name)
    {
        throw new NotImplementedException();
    }

    public decimal GetPokemonRating(int PokemonId)
    {
        throw new NotImplementedException();
    }

    public bool PokemonExists(int PokemonId)
    {
        throw new NotImplementedException();
    }
}
