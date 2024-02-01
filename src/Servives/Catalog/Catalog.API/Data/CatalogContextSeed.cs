using Catalog.API.Entities;
using MongoDB.Driver;
using System.Collections.Generic;

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
            List<SocialType> socialTypes =
            [
                new SocialType()
                {
                    Id = 1,
                    Name = "telegram"
                },
                new SocialType()
                {
                    Id = 2,
                    Name = "instagram"
                }
            ];

            List<Consultant> consultants =
            [
                new Consultant()
                {
                    Id = 1,
                    Name = "Maryna",
                    Surname = "Subach",
                    Email = "marsub@gmail.com",
                    ModilePhone = "12345678",
                    SocialType = socialTypes[0],
                    Social = "mrg"
                }
            ];

            List<Category> categories =
            [
                new Category()
                {
                    Id = 1,
                    Name = "Son"
                }
            ];
            return new List<Product>()
            {
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f5",
                    Consultant = consultants[0],
                    Category = categories[0],
                    Currency = "usd",
                    Description = "First Product Description",
                    Name = "First Product",
                    Price = 50
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f4",
                    Consultant = consultants[0],
                    Category = categories[0],
                    Currency = "usd",
                    Description = "Second Product Description",
                    Name = "Second Product",
                    Price = 50
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f3",
                    Consultant = consultants[0],
                    Category = categories[0],
                    Currency = "usd",
                    Description = "Third Product Description",
                    Name = "Third Product",
                    Price = 50
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f2",
                    Consultant = consultants[0],
                    Category = categories[0],
                    Currency = "usd",
                    Description = "Fourth Product Description",
                    Name = "Fourth Product",
                    Price = 50
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f1",
                    Consultant = consultants[0],
                    Category = categories[0],
                    Currency = "usd",
                    Description = "Fifth Product Description",
                    Name = "Fifth Product",
                    Price = 50
                }
            };
        }
    }
}
