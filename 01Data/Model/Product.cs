using System;
using System.ComponentModel.DataAnnotations;

namespace _01Data.Model
{
    public class Product: IMyBaseInterfaceJustForId, IMyBaseInterfaceJustForName

    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; } 
        public Category Category { get; set; }

       
    }
}
