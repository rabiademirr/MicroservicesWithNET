using TrainingCourses.Services.Catalog.Dtos;
using TrainingCourses.Shared.Dtos;

namespace TrainingCourses.Services.Catalog.Services
{
    public interface ICategoryService
	{
        Task<Response<List<CategoryDto>>> GetAllAsync();
        Task<Response<CategoryDto>> CreateAsync(CategoryDto category);
        Task<Response<CategoryDto>> GetIdByAsync(string id);


    }
}

