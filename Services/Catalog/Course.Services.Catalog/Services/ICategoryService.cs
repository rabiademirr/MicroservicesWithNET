using TrainingCourses.Services.Catalog.Dtos;
using TrainingCourses.Services.Catalog.Models;
using TrainingCourses.Shared.Dtos;

namespace TrainingCourses.Services.Catalog.Services
{
    public interface ICategoryService
	{
        Task<Response<List<CategoryDto>>> GetAllAsync();
        Task<Response<CategoryDto>> CreateAsync(Category category);
        Task<Response<CategoryDto>> GetIdByAsync(string id);


    }
}

