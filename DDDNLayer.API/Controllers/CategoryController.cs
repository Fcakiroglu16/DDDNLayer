using DDDNLayer.Application.Category.Dtos;
using DDDNLayer.Application.Category.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DDDNLayer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(CategoryDto categoryDto)
        {
            var result = await _categoryService.Add(categoryDto);

            return Ok(result);
        }
    }
}