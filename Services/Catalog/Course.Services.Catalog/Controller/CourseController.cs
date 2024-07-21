using Microsoft.AspNetCore.Mvc;
using TrainingCourses.Services.Catalog.Dtos;
using TrainingCourses.Services.Catalog.Services;
using TrainingCourses.Shared.BaseController;

namespace TrainingCourses.Services.Catalog.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : CustomBaseController

    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCoursesById(string id)
        {
            var response = await _courseService.GetByIdAsync(id);

            return CreateActionResult(response);

        }
        [HttpGet]
        public async Task<IActionResult> GetAllCourses()
        {
            var response = await _courseService.GetAllAsync();

            return CreateActionResult(response);

        }

        [Route("/api/[controller]/GetCoursesByUserId/{userId}")]
        public async Task<IActionResult> GetCoursesByUserId(string userId)
        {
            var response = await _courseService.GetAllByUserIdAsync(userId);

            return CreateActionResult(response);

        }

        [HttpPost]
        public async Task<IActionResult> CreateCourse(CourseCreateDto courseCreateDto)
        {
            var response = await _courseService.CreateAsync(courseCreateDto);

            return CreateActionResult(response);

        }

        [HttpPut]
        public async Task<IActionResult> UpdateCourse(CourseUpdateDto courseUpdateDto)
        {
            var response = await _courseService.UpdateAsync(courseUpdateDto);

            return CreateActionResult(response);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourse(string id)
        {
            var response = await _courseService.DeleteAsync(id);

            return CreateActionResult(response);

        }
    }
}

