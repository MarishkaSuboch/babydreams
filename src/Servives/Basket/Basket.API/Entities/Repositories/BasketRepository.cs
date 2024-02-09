
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;

namespace Basket.API.Entities.Repositories
{
    public class BasketRepository(IDistributedCache redisCache) : IBasketRepository
    {
        private readonly IDistributedCache _redisCache = redisCache ?? throw new ArgumentNullException(nameof(redisCache));

        public async Task<Basket> GetBasketsAsync(string userName)
        {
            var basket = await _redisCache.GetStringAsync(userName);
            return string.IsNullOrEmpty(basket) ? null : JsonConvert.DeserializeObject<Basket>(basket);
        }

        public async Task<Basket> UpdateBasketAsync(Basket basket)
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
