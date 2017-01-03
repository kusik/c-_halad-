using System.ComponentModel.DataAnnotations;

namespace _01Data.Model
{
    public class Product: MyBaseClassJustForId

    {
       
        public string Name { get; set; }
        public decimal Price { get; set; } 
        public Category Category { get; set; }
        

    }
}
