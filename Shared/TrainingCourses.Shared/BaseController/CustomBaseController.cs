using Microsoft.AspNetCore.Mvc;
using TrainingCourses.Shared.Dtos;

namespace TrainingCourses.Shared.BaseController
{
    public class CustomBaseController : ControllerBase
	{
		public IActionResult CreateActionResult<T>(Response<T> response)
		{
			return new ObjectResult(response)
			{
				StatusCode = response.StatusCode
			};
		}
	}
}

