using NUnit.Framework;
using Catalog.API.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.Net;
using System.Threading;
using Amazon.Runtime.Internal.Util;
using Catalog.API.Data;
using Catalog.API.Entities.Repositories;
using Catalog.API.Entities;
using Moq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Catalog.API.Controllers.Tests
{
    [TestFixture()]
    public class CatalogControllerTests
    {
        private Moq.Mock<IProductRepository> _productRepoMock;
        private IEnumerable<Product> _products;
        private Moq.Mock<ILogger<CatalogController>> _loggerMock;
        [SetUp]
        public void Setup()
        {
            _productRepoMock = new Mock<IProductRepository>();
            _loggerMock = new Mock<ILogger<CatalogController>>();
            _products = GetProducts();
        }

        [Test()]
        public async Task GetProductsTest()
        {
            _productRepoMock.Setup(p => p.GetProductsAsync()).ReturnsAsync(_products);
            var controller = new CatalogController(_productRepoMock.Object, _loggerMock.Object);

            var result = await controller.GetProducts();
            var response = result.Result as OkObjectResult;
            var value = response.Value as IEnumerable<Product>;

            Assert.That(result, Is.InstanceOf<ActionResult<IEnumerable<Product>>>());
            Assert.That(response, Is.Not.Null);
            Assert.That(response.StatusCode.Value, Is.EqualTo(200));
            Assert.That(value.Count(), Is.EqualTo(_products.Count()));
        }

        [Test()]
        public void GetProductsByIdTest()
        {

        }

        [Test()]
        public void GetProductsByCategoryTest()
        {

        }

        [Test()]
        public void GetProductsByConsultantTest()
        {

        }

        [Test()]
        public void CreateProductTest()
        {

        }

        [Test()]
        public void UpdateProductTest()
        {

        }

        [Test()]
        public void DeleteProductByIdTest()
        {

        }

        private IEnumerable<Product> GetProducts()
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