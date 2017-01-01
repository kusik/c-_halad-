using _01Data.Model;
using System;

namespace _02Repository
{
    public class GeneralRepository<TEntity>
        where TEntity : class
    {
        private DataContext db;

        public GeneralRepository(DataContext db)
        {
            this.db = db;
        }

        public void Add(TEntity cat)
        {

            db.Set<TEntity>().Add(cat);
           
        }

        public TEntity Find(params object[] keys)
        {
           
               return db.Set<TEntity>().Find(keys);
           
        }

        public void Delete(TEntity cat)
        {
            db.Set<TEntity>().Remove(cat);
        }

        public void Update(TEntity oldCat)
        {
            var entry = db.Entry(oldCat);

            if (entry.State==System.Data.Entity.EntityState.Detached)
            {
                this.db.Set<TEntity>()
                    .Attach(oldCat);

            }

            db.Entry(oldCat).State = System.Data.Entity.EntityState.Modified;
        }
    }
}