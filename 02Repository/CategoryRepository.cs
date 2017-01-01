using _01Data.Model;
using System;

namespace _02Repository
{
    public class CategoryRepository
    {
        private DataContext db;

        public CategoryRepository(DataContext db)
        {
            this.db = db;
        }

        public void Add(Category cat)
        {
           
                db.Categories.Add(cat);
           
        }

        public Category Find(int id)
        {
           
               return db.Categories.Find(id);
           
        }
    }
}