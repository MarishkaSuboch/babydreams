using Catalog.API.Data;
using Moq;

namespace Catalog.API.Entities.Repositories.Tests
{
    [TestFixture()]
    public class ProductRepositoryTests
    {
        private Moq.Mock<IProductRepository> mock;
        private IEnumerable<Product> products;
        [SetUp]
        public void Setup()
        {
            mock = new Mock<IProductRepository>();
            //products = CatalogContextSeed.SeedDataTest;
        }
        [Test()]
        public void CreateProductAsyncTest()
        {

        }

        [Test()]
        public void DeleteProductAsyncTest()
        {

        }

        [Test()]
        public void GetProductByCategoryAsyncTest()
        {

        }

        [Test()]
        public void GetProductByConsultantAsyncTest()
        {

        }

        [Test()]
        public void GetProductByIdAsyncTest()
        {

        }

        [Test()]
        public void GetProductsAsyncTest()
        {
            mock.Setup(p => p.GetProductsAsync());
            Assert.That(mock.Object.GetProductsAsync().Result.Count(), Is.EqualTo(products.Count()));
        }

        [Test()]
        public void UpdateProductAsyncTest()
        {

        }

        
    }
}