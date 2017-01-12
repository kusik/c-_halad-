using _01Data.Model;
using System;
using System.Linq;

namespace _02Repository
{
    public class GeneralRepository<TEntity>
        where TEntity : class, IMyBaseInterfaceJustForName
    {
        private DataContext db;

        public GeneralRepository(){}

        public GeneralRepository(DataContext db)
        {
            this.db = db;
        }

        public virtual void Add(TEntity cat)
        {

            db.Set<TEntity>().Add(cat);
           
        }

        public virtual TEntity Find(params object[] keys)
        {
           
               return db.Set<TEntity>().Find(keys);
           
        }

        public void Remove(TEntity cat)
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

        public virtual bool IsExistByName(string name)
        {
            return db.Set<TEntity>().Any(e => e.Name == name);
        }

        public IQueryable<TEntity> FindAll()
        {
            return db.Set<TEntity>();

        }
    }
}