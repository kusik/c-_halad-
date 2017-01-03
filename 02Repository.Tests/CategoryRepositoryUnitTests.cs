using _01Data.Model;
using NUnit.Framework;

namespace _02Repository.Tests
{
    [Category("Unit")]
    [TestFixture]
    public class CategoryRepositoryUnitTests
    {
        [Test]
        public void RepositoryUnitTests_Category_AddedCategoryShouldBeAppearInRep()
        {

            using (var db = MockFactory.GetDatacontext())
            {

                //sut: System Under Test
                var sut = new GeneralRepository<Category>(db);

                var cat = new Category() { Name = "Category a Repo tesztből" };
                sut.Add(cat);


                var newCat = sut.Find(cat.Id);

                Assert.IsNotNull(newCat);
                Assert.AreEqual(cat.Name, newCat.Name);

                sut.Remove(cat);

            }

        }

        [Test]
        public void RepositoryUnitTests_Category_DeletedCategoryShouldBeDisappearInRepo()
        {
            //sut: System Under Test
            using (var db = MockFactory.GetDatacontext())
            {
                var sut = new GeneralRepository<Category>(db);

                var cat = sut.Find(3);
                sut.Remove(cat);           
                var newCat = sut.Find(3);

                Assert.IsNull(newCat);
            }
        }

        [Test]
        public void RepositoryTests_Category_FindCategory()
        {
            using (var db = MockFactory.GetDatacontext())
            {
                var sut = new GeneralRepository<Category>(db);

                var cat = sut.Find(1);

                Assert.AreEqual(cat.Name, "Processzorok");
            }
        }
    }
}
