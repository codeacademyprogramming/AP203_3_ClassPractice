using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Product
    {
        public Product(string name,string brand,double price)
        {
            this.Name = name;
            this.BrandName = brand;
            this.Price = price;
        }
        public string Name;
        public string BrandName;
        public double Price;

        public string GetInfo()
        {
            return $"Name : {this.Name} - Brand: {this.BrandName} - Price: {this.Price}";
        }
    }
}
