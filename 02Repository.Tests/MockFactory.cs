using _01Data.Model;
using Moq;
using System.Collections.Generic;
using System.Data.Entity;

namespace _02Repository.Tests
{
    public static class MockFactory
    {
        public static DataContext GetDatacontext()
        {
            // ezzel lemásoljuk a DataContext teljes felületét.

            var mockContext = new Mock<DataContext>();

            var cat1 = new Category() { Id = 1, Name = "Processzorok" };
            var cat2 = new Category() { Id = 2, Name = "Memóriák" };

            var listaCategory = new List<Category>()
            {
              cat1,
              cat2,
              new Category() {Id=3, Name = "Monitorok" }
            };

            var listaProduct = new List<Product>()
            {
               new Product() {Id=1, Name="i5", Price= 1,Category=cat1},
               new Product() {Id=2,Name = "i7", Price = 2,Category=cat1},
               new Product() {Id=3,Name = "8GB", Price = 1 ,Category=cat2},
               new Product() {Id=4,Name = "16GB", Price = 2 ,Category=cat2},
               new Product() {Id=5,Name = "32GB", Price = 3 ,Category=cat2}
            };

            mockContext.Setup(c => c.Set<Category>())
                .Returns(GetDbSet<Category>(listaCategory));

            mockContext.Setup(c => c.Set<Product>())
               .Returns(GetDbSet<Product>(listaProduct));


            return mockContext.Object;

        }

        private static DbSet<Tentity> GetDbSet<Tentity>(List<Tentity> lista)
            where Tentity : MyBaseClassJustForId
        {

            var mockSet = new Mock<DbSet<Tentity>>();

            // beállítjuk az "add" függvényt
            mockSet.Setup(set => set.Add(It.IsAny<Tentity>()))
                .Callback<Tentity>(entity=> lista.Add(entity));

            // beállítjuk a "find" függvényt
            mockSet.Setup(set => set.Find(It.IsAny<object[]>()))
              .Returns<object[]>(ids=>lista.Find(x => x.Id == (int)ids[0]));

            mockSet.Setup(del => del.Remove(It.IsAny<Tentity>()))
                .Callback<Tentity>(cat => lista.Remove(cat));


            return mockSet.Object;
        }
               

    }
}
