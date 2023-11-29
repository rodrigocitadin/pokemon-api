using PokemonApi.Data;
using PokemonApi.Interfaces;
using PokemonApi.Models;

namespace PokemonApi.Repository;

public class OwnerRepository : IOwnerRepository
{
    private readonly DataContext _context;

    public OwnerRepository(DataContext context)
    {
       _context = context; 
    }

    public Owner GetOwner(int id) => _context
        .Owners
        .First(o => o.Id == id);

    public Owner GetOwner(string name) => _context
        .Owners
        .First(o => o.Name == name);

    public ICollection<Owner> GetOwners() => _context
        .Owners
        .ToList();
}
