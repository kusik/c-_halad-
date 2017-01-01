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

        public void Delete(Category cat)
        {
            db.Categories.Remove(cat);
        }

        public void Update(Category oldCat)
        {
            var entry = db.Entry(oldCat);

            if (entry.State==System.Data.Entity.EntityState.Detached)
            {
                db.Set<Category>()
                    .Attach(oldCat);

            }

            db.Entry(oldCat).State = System.Data.Entity.EntityState.Modified;
        }
    }
}