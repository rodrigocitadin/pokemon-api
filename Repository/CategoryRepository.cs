using PokemonApi.Data;
using PokemonApi.Interfaces;
using PokemonApi.Models;

namespace PokemonApi.Repository;

public class CategoryRepository : ICategoryRepository
{
    private readonly DataContext _context;

    public CategoryRepository(DataContext context)
    {
        _context = context;
    }

    public ICollection<Category> GetCategories() => _context.Categories.ToList();

    public Category? GetCategory(int id) => _context.Categories.First(c => c.Id == id);

    public Category? GetCategory(string name) => _context.Categories.First(c => c.Name == name);
}
