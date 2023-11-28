using PokemonApi.Models;

namespace PokemonApi.Interfaces;

public interface IReviewRepository
{
    ICollection<Review> GetReviews();
    Review GetReview(int id);
    Review GetReview(string id);
}
