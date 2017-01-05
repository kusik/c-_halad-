using _01Data.Model;
using _02Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Service
{
    public class CategoryService
    {
        private UnitOfWorks uow;

        public CategoryService(UnitOfWorks unitOfWorks)
        {
            this.uow = unitOfWorks;
        }

        public  void Add(string name)
        {
            uow.CategoryRepository.Add(new Category() { Name=name });
            uow.Save();
        }


        public  bool IsExistGetByName(string name)
        {
            bool exist=uow.CategoryRepository.IsExistByName(name);
            return exist;
        }
    }
}
