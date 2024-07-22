using Microsoft.AspNetCore.Mvc;
using TrainingCourses.Services.Catalog.Dtos;
using TrainingCourses.Services.Catalog.Services;
using TrainingCourses.Shared.BaseController;

namespace TrainingCourses.Services.Catalog.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : CustomBaseController

    {
        private readonly ICategoryService _categoyService;

        public CategoryController(ICategoryService categoyService)
        {
            _categoyService = categoyService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var categories = await _categoyService.GetAllAsync();

            return CreateActionResult(categories);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoriesById(string id)
        {
            var category = await _categoyService.GetIdByAsync(id);

            return CreateActionResult(category);

        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CategoryDto  categoryDto)
        {
            var newCategory = await _categoyService.CreateAsync(categoryDto);

            return CreateActionResult(newCategory);



        }


 
    }

}

