using Microsoft.AspNetCore.Mvc;
using TrainingCourses.Services.Basket.Dtos;
using TrainingCourses.Services.Basket.Services;
using TrainingCourses.Shared.BaseController;

namespace TrainingCourses.Services.Basket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketsController : CustomBaseController

    {
        private readonly IBasketService _basketService;

        public BasketsController(IBasketService basketService)
        {
            _basketService = basketService;
        }

        [HttpGet]
        public async Task<IActionResult> GetBasket()
        {
            return CreateActionResult(await _basketService.GetBasket("78432433"));
        }

        [HttpPost]
        public async Task<IActionResult> SaveOrUpdateBasket(BasketDto basketDto)
        {

            return CreateActionResult(await _basketService.SaveOrUpdate(basketDto));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBasket(string userId)
        {
            return CreateActionResult(await _basketService.DeleteBasket(userId));
        }
    }
}

