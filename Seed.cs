using PokemonApi.Data;
using PokemonApi.Models;

namespace PokemonApi;

public class Seed
{
    private readonly DataContext dataContext;

    public Seed(DataContext context) => this.dataContext = context;

    public void SeedDataContext()
    {
        if (!dataContext.PokemonOwners.Any())
        {
            var pokemonOwners = new List<PokemonOwner>()
            {
                new PokemonOwner()
                {
                    Pokemon = new Pokemon()
                    {
                        Name = "Pikachu",
                        BirthDate = new DateTime(1903, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                        PokemonCategories = new List<PokemonCategory>()
                        {
                            new PokemonCategory { Category = new Category() { Name = "Electric" } }
                        },
                        Reviews = new List<Review>()
                        {
                            new Review
                            {
                                Title = "Pikachu",
                                Rating = 4.5m,
                                Text = "Pickahu is the best pokemon, because it is electric",
                                Reviewer = new Reviewer()
                                {
                                    FirstName = "Teddy",
                                    LastName = "Smith"
                                }
                            },
                            new Review
                            {
                                Title = "Pikachu",
                                Rating = 3.5m,
                                Text = "Pickachu is the best a killing rocks",
                                Reviewer = new Reviewer()
                                {
                                    FirstName = "Taylor",
                                    LastName = "Jones"
                                }
                            },
                            new Review
                            {
                                Title = "Pikachu",
                                Rating = 2m,
                                Text = "Pickchu, pickachu, pikachu",
                                Reviewer = new Reviewer()
                                {
                                    FirstName = "Jessica",
                                    LastName = "McGregor"
                                }
                            },
                        }
                    },
                    Owner = new Owner()
                    {
                        Name = "Jack London",
                        Gym = "Brocks Gym",
                        Country = new Country() { Name = "Kanto" }
                    }
                },
                new PokemonOwner()
                {
                    Pokemon = new Pokemon()
                    {
                        Name = "Squirtle",
                        BirthDate = new DateTime(1903, 1, 1, 0, 0,0 , DateTimeKind.Utc),
                        PokemonCategories = new List<PokemonCategory>()
                        {
                            new PokemonCategory { Category = new Category() { Name = "Water" } }
                        },
                        Reviews = new List<Review>()
                        {
                            new Review
                            {
                                Title = "Squirtle",
                                Rating = 1m,
                                Text = "squirtle is the best pokemon, because it is electric",
                                Reviewer = new Reviewer()
                                {
                                    FirstName = "Teddy",
                                    LastName = "Smith"
                                }
                            },
                            new Review
                            {
                                Title = "Squirtle",
                                Rating = 3.5m,
                                Text = "Squirtle is the best a killing rocks",
                                Reviewer = new Reviewer()
                                {
                                    FirstName = "Taylor",
                                    LastName = "Jones"
                                }
                            },
                            new Review
                            {
                                Title = "Squirtle",
                                Rating = 4.5m,
                                Text = "squirtle, squirtle, squirtle",
                                Reviewer = new Reviewer()
                                {
                                    FirstName = "Jessica",
                                    LastName = "McGregor"
                                }
                            },
                        }
                    },
                    Owner = new Owner()
                    {
                        Name = "Harry Potter",
                        Gym = "Mistys Gym",
                        Country = new Country() { Name = "Saffron City" }
                    }
                },
                new PokemonOwner()
                {
                    Pokemon = new Pokemon()
                    {
                        Name = "Venasuar",
                        BirthDate = new DateTime(1903, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                        PokemonCategories = new List<PokemonCategory>()
                        {
                            new PokemonCategory { Category = new Category() { Name = "Leaf" } }
                        },
                        Reviews = new List<Review>()
                        {
                            new Review
                            {
                                Title = "Veasaur",
                                Rating = 1.5m,
                                Text = "Venasuar is the best pokemon, because it is electric",
                                Reviewer = new Reviewer()
                                {
                                    FirstName = "Teddy",
                                    LastName = "Smith"
                                }
                            },
                            new Review
                            {
                                Title = "Veasaur",
                                Rating = 0.5m,
                                Text = "Venasuar is the best a killing rocks",
                                Reviewer = new Reviewer()
                                {
                                    FirstName = "Taylor",
                                    LastName = "Jones"
                                }
                            },
                            new Review
                            {
                                Title = "Veasaur",
                                Rating = 4.0m,
                                Text = "Venasuar, Venasuar, Venasuar",
                                Reviewer = new Reviewer()
                                {
                                    FirstName = "Jessica",
                                    LastName = "McGregor"
                                }
                            },
                        }
                    },
                    Owner = new Owner()
                    {
                        Name = "Ash Ketchum",
                        Gym = "Ashs Gym",
                        Country = new Country() { Name = "Millet Town" }
                    }
                }
            };
            dataContext.PokemonOwners.AddRange(pokemonOwners);
            dataContext.SaveChanges();
        }
    }
}
