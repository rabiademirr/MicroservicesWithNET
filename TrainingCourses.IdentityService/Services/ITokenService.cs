using TrainingCourses.IdentityService.Dtos;

namespace TrainingCourses.IdentityService.Services
{
	public interface ITokenService
	{
        string GenerateToken(User user);

    }
}

