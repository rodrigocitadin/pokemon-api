using PokemonApi.Models;

namespace PokemonApi.Interfaces;

public interface IReviewRepository
{
    ICollection<Review> GetReviews();
    ICollection<Review> GetReviews(string title);
    Review GetReview(int id);
}
