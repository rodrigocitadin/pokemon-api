using PokemonApi.Data;
using PokemonApi.Interfaces;
using PokemonApi.Models;

namespace PokemonApi.Repository;

public class CountryRepository : ICountryRepository
{
    private readonly DataContext _context;

    public CountryRepository(DataContext context)
    {
        _context = context;
    }

    public ICollection<Country> GetCountries() => _context
        .Countries
        .ToList();

    public Country GetCountry(int id) => _context
        .Countries
        .First(c => c.Id == id);

    public Country GetCountry(string name) => _context
        .Countries
        .First(c => c.Name == name);
}
