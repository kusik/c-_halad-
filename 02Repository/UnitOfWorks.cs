using _01Data.Model;

namespace _02Repository
{
    public class UnitOfWorks
    {
        private DataContext db;

        public UnitOfWorks()
        {
            db = new DataContext();
            CategoryRepository = new GeneralRepository<Category>(db);
            ProductRepository = new GeneralRepository<Product>(db);
        }
        public virtual GeneralRepository<Category> CategoryRepository { get; set; }
        public virtual GeneralRepository<Product> ProductRepository { get;  set; }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
