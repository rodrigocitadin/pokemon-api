using PokemonApi.Data;
using PokemonApi.Interfaces;
using PokemonApi.Models;

namespace PokemonApi.Repository;

public class ReviewRepository : IReviewRepository
{
    private readonly DataContext _context;

    public ReviewRepository(DataContext context)
    {
       _context = context; 
    }

    public Review GetReview(int id) => _context
        .Reviews
        .First(r => r.Id == id);

    public ICollection<Review> GetReviews(string title) => _context
        .Reviews
        .Where(r => r.Title == title)
        .ToList();

    public ICollection<Review> GetReviews() => _context
        .Reviews
        .ToList();
}
