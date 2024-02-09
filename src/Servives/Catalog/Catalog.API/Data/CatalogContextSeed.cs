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
            List<Category> categories =
            [
                new Category()
                {
                    Id = 1,
                    Name = "Son"
                },
                new Category()
                {
                    Id = 1,
                    Name = "Food"
                },
                new Category()
                {
                    Id = 1,
                    Name = "GV"
                }
            ];

            List<SubCategory> subCategories =
            [
                new SubCategory()
                {
                    Id = 1,
                    Name = "Consultation"
                },
                new SubCategory()
                {
                    Id = 2,
                    Name = "SupportLite"
                },
                new SubCategory()
                {
                    Id = 3,
                    Name = "SupportVip"
                }
            ];

            List<Consultant> consultants =
            [
                new Consultant()
                {
                    Id = 1,
                    Name = "Anna",
                    Surname = "Ivanova",
                    Email = "example@gmail.com",
                    PhoneNumber = "12345678",
                    Social = "mrg",
                    Description = "Good specialist",
                    WorkTineFrom = new TimeOnly(8, 0),
                    WorkTineTo = new TimeOnly(18, 0),
                    TimeZone = TimeZoneInfo.Local
                },
                new Consultant()
                {
                    Id = 2,
                    Name = "Ola",
                    Surname = "Petrova",
                    Email = "example@gmail.com",
                    PhoneNumber = "12345678",
                    Social = "mrg",
                    Description = "Good specialist",
                    WorkTineFrom = new TimeOnly(8, 0),
                    WorkTineTo = new TimeOnly(18, 0),
                    TimeZone = TimeZoneInfo.Local
                },
                new Consultant()
                {
                    Id = 3,
                    Name = "Helen",
                    Surname = "Sidorova",
                    Email = "example@gmail.com",
                    PhoneNumber = "12345678",
                    Social = "mrg",
                    Description = "Good specialist",
                    WorkTineFrom = new TimeOnly(8, 0),
                    WorkTineTo = new TimeOnly(18, 0),
                    TimeZone = TimeZoneInfo.Local
                }
            ];


            return new List<Product>()
            {
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f5",
                    Category = categories[0],
                    SubCategory = subCategories[0],
                    Consultant = consultants[0],
                    Date = new DateTime(new DateOnly(2024, 2,1 ), new TimeOnly(10, 0)),
                    Price = 50,
                    Currency = "usd"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f4",
                    Category = categories[1],
                    SubCategory = subCategories[0],
                    Consultant = consultants[2],
                    Date = new DateTime(new DateOnly(2024, 2,13 ), new TimeOnly(10, 0)),
                    Price = 50,
                    Currency = "usd"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f3",
                    Category = categories[0],
                    SubCategory = subCategories[2],
                    Consultant = consultants[2],
                    Date = new DateTime(new DateOnly(2024, 2,10 ), new TimeOnly(10, 0)),
                    Price = 50,
                    Currency = "usd"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f2",
                    Category = categories[1],
                    SubCategory = subCategories[1],
                    Consultant = consultants[1],
                    Date = new DateTime(new DateOnly(2024, 2,12 ), new TimeOnly(10, 0)),
                    Price = 50,
                    Currency = "usd"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f1",
                    Category = categories[2],
                    SubCategory = subCategories[0],
                    Consultant = consultants[0],
                    Date = new DateTime(new DateOnly(2024, 2,1 ), new TimeOnly(10, 0)),
                    Price = 50,
                    Currency = "usd"
                }
            };
        }
    }
}
