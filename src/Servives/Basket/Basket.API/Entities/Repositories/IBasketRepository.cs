namespace Basket.API.Entities.Repositories
{
    public interface IBasketRepository
    {
        Task<BasketCart> GetBasketsAsync(string userName);
        Task<BasketCart> UpdateBasketAsync(BasketCart basket);
        Task DeleteBasketAsync(string userName);
    }
}
