using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetConfiguredProducts());
            }
        }

        private static IEnumerable<Product> GetConfiguredProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f5",
                    Category_ID = 1,
                    Consultant_ID = 1,
                    Currency = "usd",
                    Description = "First Product Description",
                    Name = "First Product",
                    Price = 50
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f4",
                    Category_ID = 1,
                    Consultant_ID = 1,
                    Currency = "usd",
                    Description = "Second Product Description",
                    Name = "Second Product",
                    Price = 50
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f3",
                    Category_ID = 1,
                    Consultant_ID = 1,
                    Currency = "usd",
                    Description = "Third Product Description",
                    Name = "Third Product",
                    Price = 50
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f2",
                    Category_ID = 1,
                    Consultant_ID = 1,
                    Currency = "usd",
                    Description = "Fourth Product Description",
                    Name = "Fourth Product",
                    Price = 50
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f1",
                    Category_ID = 1,
                    Consultant_ID = 1,
                    Currency = "usd",
                    Description = "Fifth Product Description",
                    Name = "Fifth Product",
                    Price = 50
                }
            };
        }
    }
}
