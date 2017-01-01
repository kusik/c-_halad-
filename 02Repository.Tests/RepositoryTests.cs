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
            UnitOfWorks uow = new UnitOfWorks();
            var cat = new Category() { Name="Category a Repo tesztből"};
            uow.CategoryRepository.Add(cat);
            uow.Save();

            var newCat = uow.CategoryRepository.Find(cat.Id);

            Assert.IsNotNull(newCat);
            Assert.AreEqual(cat.Name, newCat.Name);
        }
    }
}