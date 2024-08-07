﻿using System;
using System.Text.Json;
using TrainingCourses.Services.Basket.Dtos;
using TrainingCourses.Shared.Dtos;

namespace TrainingCourses.Services.Basket.Services
{
    public class BasketService : IBasketService
    {
        private readonly RedisService _redisService;

        public BasketService(RedisService redisService)
        {
            _redisService = redisService;
        }

        public async Task<Response<bool>> DeleteBasket(string userId)
        {
            var status = await _redisService.GetDatabase().KeyDeleteAsync(userId);

            return status ? Response<bool>.Success(204) : Response<bool>.Error("Basket not found!", 404);
        }

        public async Task<Response<BasketDto>> GetBasket(string userId)
        {
            var existBasket = await _redisService.GetDatabase().StringGetAsync(userId);

            if (string.IsNullOrEmpty(existBasket))
            {
                return Response<BasketDto>.Error("Basket Not Found!", 404);
            }

            return Response<BasketDto>.Success(JsonSerializer.Deserialize<BasketDto>(existBasket), 200);
        }

        public async Task<Response<bool>> SaveOrUpdate(BasketDto basketDto)
        {

            var status = await _redisService.GetDatabase().StringSetAsync(basketDto.UserId, JsonSerializer.Serialize(basketDto));

            return status ? Response<bool>.Success(204) : Response<bool>.Error("Could not update or save!", 500);
        }
    }
}

