using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PokemonApi.Dto;
using PokemonApi.Interfaces;
using PokemonApi.Models;

namespace PokemonApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : Controller
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public CategoryController(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(200, Type = typeof(IEnumerable<Category>))]
    public IActionResult GetCategories()
    {
        var categories = _mapper.Map<List<CategoryDto>>(_categoryRepository.GetCategories());

        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        return Ok(categories);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(200, Type = typeof(Category))]
    [ProducesResponseType(400)]
    public IActionResult GetCategory(int id)
    {
        var category = _mapper.Map<CategoryDto>(_categoryRepository.GetCategory(id));

        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        return Ok(category);
    }
}
