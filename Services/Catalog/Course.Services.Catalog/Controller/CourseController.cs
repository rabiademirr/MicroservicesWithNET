using Microsoft.AspNetCore.Mvc;
using TrainingCourses.Services.Catalog.Services;
using TrainingCourses.Shared.BaseController;

namespace TrainingCourses.Services.Catalog.Controller
{
    [Route("api/[controller]")]
    public class CourseController : CustomBaseController

    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public async Task<IActionResult> GetById(string id)
        {
            var response = await _courseService.GetByIdAsync(id);

            return CreateActionResult(response);

         
        }
    }
}

