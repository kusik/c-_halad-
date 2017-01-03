using NUnit.Framework;
using _01Data.Model;

using System.Data.Entity.Infrastructure;

namespace _02Repository.Tests
{
    [Category("Integration")] //ezt készit egy kategóriát a megadott névvel.   
    [TestFixture]
    public class CategoryRepositoryTests
    {
        [Test]
        public void RepositoryTests_Category_AddedCategoryShouldBeAppearInRepo()
        {

            //todo: visszaállítani az adatbázist a végén
            UnitOfWorks uow = new UnitOfWorks();

            var cat = new Category() { Name="Category a Repo tesztből"};
            uow.CategoryRepository.Add(cat);
            

            var newCat = uow.CategoryRepository.Find(cat.Id);

            Assert.IsNotNull(newCat);
            Assert.AreEqual(cat.Name, newCat.Name);

            uow.CategoryRepository.Remove(cat);
        }

        [Test]
        public void RepositoryTests_Category_DeletedCategoryShouldBeDisappearInRepo()
        {
            UnitOfWorks uow = new UnitOfWorks();

            var cat = uow.CategoryRepository.Find(3);
            uow.CategoryRepository.Remove(cat);
            uow.Save();
            var newCat = uow.CategoryRepository.Find(3);

            Assert.IsNull(newCat);
        }

        [Test]
        public void RepositoryTests_Category_UpdateCategoryShouldBeAppearInRepo()
        {
            UnitOfWorks uow = new UnitOfWorks();

            var oldCat= uow.CategoryRepository.Find(2);
            var oldName = oldCat.Name;
            string newName = "Nagyméretű memóriák";

            oldCat.Name = newName;

            
            uow.CategoryRepository.Update(oldCat);
            uow.Save();

            var newCat = uow.CategoryRepository.Find(2);

            Assert.AreEqual(newCat.Name, newName);

            oldCat.Name = oldName;
            uow.CategoryRepository.Update(oldCat);
            uow.Save();
        }

        [Test]
        public void RepositoryTests_Category_FindCategory()
        {
            UnitOfWorks uow = new UnitOfWorks();

            var cat = uow.CategoryRepository.Find(1);

            Assert.AreEqual(cat.Name, "Processzorok");
        }

        [Test]
        public void RepositoryTests_Category_DeleteCategoryTrowException()
        {
            UnitOfWorks uow = new UnitOfWorks();

            var cat = uow.CategoryRepository.Find(1);
            uow.CategoryRepository.Remove(cat);

            Assert.Throws<DbUpdateException>(uow.Save);
        }
    }
}