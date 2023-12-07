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

    [HttpPost]
    [ProducesResponseType(201, Type = typeof(Category))]
    [ProducesResponseType(400)]
    public IActionResult CreateCategory(CategoryDto category)
    {
        if (category == null) return BadRequest(ModelState);
    
        var categoryAlreadyExists = _categoryRepository
            .GetCategories()
            .Where(c => c.Name.Trim().ToUpper() == category.Name.Trim().ToUpper())
            .FirstOrDefault();
    
        if (categoryAlreadyExists != null)
        {
            ModelState.AddModelError("", "Category already exists");
            return BadRequest(ModelState);
        }

        if (!ModelState.IsValid) return BadRequest(ModelState);

        var categoryMap = _mapper.Map<Category>(category);

        var createdCategory = _categoryRepository.CreateCategory(categoryMap);

        if (createdCategory == null)
        {
            ModelState.AddModelError("", "something went wrong while saving");
            return StatusCode(500, ModelState);
        }

        return StatusCode(201, createdCategory);
    }
}
