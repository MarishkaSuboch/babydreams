namespace Basket.API.Entities.Repositories
{
    public interface IBasketRepository
    {
        Task<Basket> GetBasketsAsync(string userName);
        Task<Basket> UpdateBasketAsync(Basket basket);
        Task DeleteBasketAsync(string userName);
    }
}
