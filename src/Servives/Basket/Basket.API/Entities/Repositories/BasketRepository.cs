
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;

namespace Basket.API.Entities.Repositories
{
    public class BasketRepository(IDistributedCache redisCache) : IBasketRepository
    {
        private readonly IDistributedCache _redisCache = redisCache ?? throw new ArgumentNullException(nameof(redisCache));

        public async Task<BasketCart> GetBasketsAsync(string userName)
        {
            var basket = await _redisCache.GetStringAsync(userName);
            return string.IsNullOrEmpty(basket) ? null : JsonConvert.DeserializeObject<BasketCart>(basket);
        }

        public async Task<BasketCart> UpdateBasketAsync(BasketCart basket)
        {
            await _redisCache.SetStringAsync(basket.UserName, JsonConvert.SerializeObject(basket));
            return await GetBasketsAsync(basket.UserName);
        }

        public async Task DeleteBasketAsync(string userName)
        {
            await _redisCache.RemoveAsync(userName);
        }
    }
}
