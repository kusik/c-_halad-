using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Data.Model
{
    public class DataContext : DbContext
    {

        public DbSet<Product> Products { get; set; }
        
        public  DbSet<Category> Categories { get; set; }
        

    }
}
