using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrainingCourses.Services.ImageStock.Dtos;
using TrainingCourses.Shared.BaseController;
using TrainingCourses.Shared.Dtos;



namespace TrainingCourses.Services.ImageStock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : CustomBaseController
    {
        [HttpPost]
        public async Task<IActionResult> SaveImage(IFormFile image,CancellationToken cancellationToken)
        {
            if(image != null && image.Length > 0)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/images", image.FileName);

                using (var stream = new FileStream(path,FileMode.Create))
                {
                    await image.CopyToAsync(stream, cancellationToken);

                    var returnPath = "images/" + image.FileName;

                    ImageDto imageDto = new() { Url = returnPath };

                    return CreateActionResult(Response<ImageDto>.Success(imageDto,200));
                }


            }

                return CreateActionResult(Response<ImageDto>.Error("Image empty",400));
           

        }
        
    }
}

