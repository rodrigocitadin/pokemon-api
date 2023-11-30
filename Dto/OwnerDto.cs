using PokemonApi.Models;

namespace PokemonApi.Dto;

public class OwnerDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Gym { get; set; }
    public Country Country { get; set; }
}
