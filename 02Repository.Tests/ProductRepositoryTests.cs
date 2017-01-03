using NUnit.Framework;
using _01Data.Model;

namespace _02Repository.Tests
{
    [Category("Integration")] //ezt készit egy kategóriát a megadott névvel.   

    [TestFixture]
    public class ProductRepositoryTests
    {
        [Test]
        public void RepositoryTests_Product_AddedProductShouldBeAppearInRepo()
        {

            //todo: visszaállítani az adatbázist a végén
            UnitOfWorks uow = new UnitOfWorks();

            var prod = new Product() { Name="Product a Repo tesztből"};
            uow.ProductRepository.Add(prod);
            

            var newprod = uow.ProductRepository.Find(prod.Id);

            Assert.IsNotNull(newprod);
            Assert.AreEqual(prod.Name, newprod.Name);

            uow.ProductRepository.Remove(prod);
        }

        [Test]
        public void RepositoryTests_Product_DeletedProductShouldBeDisappearInRepo()
        {
            UnitOfWorks uow = new UnitOfWorks();

            var prod = uow.ProductRepository.Find(3);
            uow.ProductRepository.Remove(prod);
            uow.Save();
            var newprod = uow.ProductRepository.Find(3);

            Assert.IsNull(newprod);
        }

        [Test]
        public void RepositoryTests_Product_UpdateProductShouldBeAppearInRepo()
        {
            UnitOfWorks uow = new UnitOfWorks();

            var oldprod= uow.ProductRepository.Find(2);
            var oldName = oldprod.Name;
            string newName = "Nagyméretű memóriák";

            oldprod.Name = newName;

            
            uow.ProductRepository.Update(oldprod);
            uow.Save();

            var newprod = uow.ProductRepository.Find(2);

            Assert.AreEqual(newprod.Name, newName);

            oldprod.Name = oldName;
            uow.ProductRepository.Update(oldprod);
            uow.Save();
        }

        [Test]
        public void RepositoryTests_Product_FindProduct()
        {
            UnitOfWorks uow = new UnitOfWorks();

            var prod = uow.ProductRepository.Find(1);

            Assert.AreEqual(prod.Name, "i5");
        }

       
    }
}