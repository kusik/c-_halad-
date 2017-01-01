using _01Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public GeneralRepository<Category> CategoryRepository { get; set; }
        public GeneralRepository<Product> ProductRepository { get;  set; }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
