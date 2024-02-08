namespace Catalog.API.Entities.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product> GetProductByIdAsync(string id);
        Task<IEnumerable<Product>> GetProductByCategoryAsync(string category);
        Task<IEnumerable<Product>> GetProductByConsultantAsync(string consultant);

        Task CreateProductAsync(Product product);
        Task<bool> UpdateProductAsync(Product product);
        Task<bool> DeleteProductAsync(string id);


    }
}
