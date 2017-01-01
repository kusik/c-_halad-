using System;
using NUnit.Framework;
using _01Data.Model;

namespace _02Repository.Tests
{
    [TestFixture]
    public class RepositoryTests
    {
        [Test]
        public void RepositoryTests_Catefory_AddedCategoryShouldBeAppearInRepo()
        {

            //todo: visszaállítani az adatbázist a végén
            UnitOfWorks uow = new UnitOfWorks();

            var cat = new Category() { Name="Category a Repo tesztből"};
            uow.CategoryRepository.Add(cat);
            

            var newCat = uow.CategoryRepository.Find(cat.Id);

            Assert.IsNotNull(newCat);
            Assert.AreEqual(cat.Name, newCat.Name);

            uow.CategoryRepository.Delete(cat);
        }

        [Test]
        public void RepositoryTests_Catefory_DeletedCategoryShouldBeDisappearInRepo()
        {
            UnitOfWorks uow = new UnitOfWorks();

            var cat = uow.CategoryRepository.Find(3);
            uow.CategoryRepository.Delete(cat);
            uow.Save();
            var newCat = uow.CategoryRepository.Find(3);

            Assert.IsNull(newCat);
        }

        [Test]
        public void RepositoryTests_Catefory_UpdateCategoryShouldBeAppearInRepo()
        {
            UnitOfWorks uow = new UnitOfWorks();

            var oldCat= uow.CategoryRepository.Find(2);
            string newName = "Nagyméretű memóriák";

            oldCat.Name = newName;

            
            uow.CategoryRepository.Update(oldCat);
            uow.Save();

            var newCat = uow.CategoryRepository.Find(2);

            Assert.AreEqual(newCat.Name, newName);
        }
    }
}