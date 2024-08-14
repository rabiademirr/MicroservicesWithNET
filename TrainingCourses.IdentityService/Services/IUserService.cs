using System;
using TrainingCourses.IdentityService.Dtos;

namespace TrainingCourses.IdentityService.Services
{
	public interface IUserService
	{
        User Authenticate(string username, string password);

    }
}

