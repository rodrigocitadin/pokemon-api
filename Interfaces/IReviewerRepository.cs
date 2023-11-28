using PokemonApi.Models;

namespace PokemonApi.Interfaces;

public interface IReviewerRepository
{
    ICollection<Reviewer> GetReviewers();
    ICollection<Reviewer> GetReviewers(string firstName);
    Reviewer GetReviewer(int id);
}
