using System;
using TrainingCourses.IdentityService.Dtos;

namespace TrainingCourses.IdentityService.Services
{
	public class UserService:IUserService
	{

        private readonly List<User> _users = new List<User>
    {
             new User { UserName = "rabiademir", Password = "75646437hdd7sds" }
    };

        public User Authenticate(string username, string password)
        {
            return _users.SingleOrDefault(u => u.UserName == username && u.Password == password);
        }
    }
}

