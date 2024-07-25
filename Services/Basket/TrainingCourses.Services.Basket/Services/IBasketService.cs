using TrainingCourses.Services.Basket.Dtos;
using TrainingCourses.Shared.Dtos;

namespace TrainingCourses.Services.Basket.Services
{
	public interface IBasketService
	{
		Task<Response<BasketDto>> GetBasket(string userId);

		Task<Response<bool>> SaveOrUpdate(BasketDto basketDto);

		Task<Response<bool>> DeleteBasket(string userId);
	}
}

