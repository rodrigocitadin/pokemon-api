using PokemonApi.Dto;
using PokemonApi.Models;

namespace PokemonApi.Interfaces;

public interface ICategoryRepository
{
    ICollection<Category> GetCategories();
    Category? GetCategory(int id);
    Category? GetCategory(string name);
    Category CreateCategory(Category category);
    bool Save();
}
