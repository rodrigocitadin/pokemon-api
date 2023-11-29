using PokemonApi.Data;
using PokemonApi.Interfaces;
using PokemonApi.Models;

namespace PokemonApi.Repository;

public class ReviewerRepository : IReviewerRepository
{
    private DataContext _context;

    public ReviewerRepository(DataContext context)
    {
        _context = context;
    }

    public Reviewer GetReviewer(int id) => _context
        .Reviewers
        .First(r => r.Id == id);

    public ICollection<Reviewer> GetReviewers() => _context
        .Reviewers
        .ToList();

    public ICollection<Reviewer> GetReviewers(string firstName) => _context
        .Reviewers
        .Where(r => r.FirstName == firstName)
        .ToList();
}
