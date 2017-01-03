using _01Data.Model;
using System.Data.Entity;

namespace _01Data.Tests
{
    public class DataTestInitializer : DropCreateDatabaseAlways<DataContext>
    {

        protected override void Seed(DataContext db)
        {
            var cat = new Category() { Name = "Processzorok" };

            var prod = new Product() { Name="i5", Price= 1};
            cat.Products.Add(prod);

            prod = new Product() { Name = "i7", Price = 2 };
            cat.Products.Add(prod);

            db.Categories.Add(cat);

            cat = new Category() { Name = "Memóriák" };

            prod = new Product() { Name = "8GB", Price = 1 };
            cat.Products.Add(prod);

            prod = new Product() { Name = "16GB", Price = 2 };
            cat.Products.Add(prod);

            prod = new Product() { Name = "32GB", Price = 3 };
            cat.Products.Add(prod);

            db.Categories.Add(cat);

            cat = new Category() { Name = "Monitorok" };
            db.Categories.Add(cat);

            db.SaveChanges();


            //base.Seed(db);
        }

    }
}
