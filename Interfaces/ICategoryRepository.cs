using PokemonApi.Models;

namespace PokemonApi.Interfaces;

interface ICategoryRepository
{
    ICollection<Category> GetCategories();
    Category? GetCategory(int id);
}
