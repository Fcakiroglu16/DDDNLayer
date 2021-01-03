using DDDNLayer.Application.Category.Dtos;
using DDDNLayer.Application.Category.Services;
using DDDNLayer.Application.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DDDNLayer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : CustomBaseController
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _categoryService.GetAll();

            return GetInstanceActionResult(response);
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(CreateCategoryDto categoryDto)
        {
            var response = await _categoryService.Add(categoryDto);
            return GetInstanceActionResult(response);
        }
    }
}