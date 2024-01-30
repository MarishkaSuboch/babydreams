
using Catalog.API.Data;
using MongoDB.Driver;
using System.Xml.Linq;

namespace Catalog.API.Entities.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ICatalogContext _catalogContext;
        public ProductRepository(ICatalogContext catalogContext)
        {
            _catalogContext = catalogContext;
        }
        public async Task CreateProductAsync(Product product)
        {
            await _catalogContext.Products.InsertOneAsync(product);
        }

        public async Task<bool> DeleteProductAsync(string id)
        {
            FilterDefinition<Product> filter = Builders<Product>.Filter.Eq(p => p.Id, id);
            DeleteResult deleteResult = await _catalogContext.Products.DeleteOneAsync(filter);
            return deleteResult.IsAcknowledged && deleteResult.DeletedCount > 0;
        }

        public async Task<IEnumerable<Product>> GetProductByCategoryAsync(string category)
        {
            FilterDefinition<Product> filter = Builders<Product>.Filter.Eq(p => p.Category.Name, category);
            return await _catalogContext.Products.Find(filter).ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProductByConsultantAsync(string consultant)
        {
            FilterDefinition<Product> filter = Builders<Product>.Filter.Eq(p => p.Category.Name, consultant);
            return await _catalogContext.Products.Find(filter).ToListAsync();
        }

        public async Task<Product> GetProductByIdAsync(string id)
        {
            return await _catalogContext.Products.Find(p => p.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _catalogContext.Products.Find(p => true).ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProductsByNameAsync(string name)
        {
            FilterDefinition<Product> filter = Builders<Product>.Filter.Eq(p => p.Name, name);
            return await _catalogContext.Products.Find(filter).ToListAsync();
        }

        public async Task<bool> UpdateProductAsync(Product product)
        {
            var updateResult = await _catalogContext.Products.ReplaceOneAsync(filter: g => g.Id == product.Id, replacement: product);
            return updateResult.IsAcknowledged && updateResult.ModifiedCount > 0;
        }
    }
}
