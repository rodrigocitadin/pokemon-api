using PokemonApi.Models;

namespace PokemonApi.Interfaces;

public interface ICountryRepository
{
    ICollection<Country> GetCountries();
    Country GetCountry(int id);
    Country GetCountry(string name);
}
