using System;
using _01Data.Model;
using NUnit.Framework;

namespace _02Repository.Tests
{
    [Category("Unit")]
    [TestFixture]
    public class ProductRepositoryUnitTests
    {
        [Test]
        public void RepositoryUnitTests_Product_AddedProductShouldBeAppearInRep()
        {

            using (var db = MockFactory.GetDatacontext())
            {

                //sut: System Under Test
                var sut = new GeneralRepository<Product>(db);

                var cat = new Product() { Name = "Product a Repo tesztből" };
                sut.Add(cat);


                var newCat = sut.Find(cat.Id);

                Assert.IsNotNull(newCat);
                Assert.AreEqual(cat.Name, newCat.Name);

                sut.Remove(cat);

            }

        }

        [Test]
        public void RepositoryUnitTests_Product_DeletedProductShouldBeDisappearInRepo()
        {
            //sut: System Under Test
            using (var db = MockFactory.GetDatacontext())
            {
                var sut = new GeneralRepository<Product>(db);

                var cat = sut.Find(3);
                sut.Remove(cat);           
                var newCat = sut.Find(3);

                Assert.IsNull(newCat);
            }
        }

        [Test]
        public void RepositoryTests_Product_FindProduct()
        {
            using (var db = MockFactory.GetDatacontext())
            {
                var sut = new GeneralRepository<Product>(db);

                var cat = sut.Find(1);

                Assert.AreEqual(cat.Name, "i5");
            }
        }
    }
}
