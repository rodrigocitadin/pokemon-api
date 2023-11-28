using PokemonApi.Models;

namespace PokemonApi.Interfaces;

public interface IOwnerRepository
{
    ICollection<Owner> GetOwners();
    Owner GetOwner(int id);
    Owner GetOwner(string name);
}
