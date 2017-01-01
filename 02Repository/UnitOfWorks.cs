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
            CategoryRepository = new CategoryRepository(db);
        }
        public CategoryRepository CategoryRepository { get; set; }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
