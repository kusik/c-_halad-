using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Data.Model
{
    public class Category : MyBaseClassJustForId
    {

        public Category()
        {
            Products = new System.Collections.Generic.List < Product >();
        }

        [MaxLength(127)]
        [Index(IsUnique = true)]
        public string Name { get; set; }
       
        public ICollection<Product> Products { get; set; }


    }
}
