using System;
using System.Collections.Generic;
using System.Text;

namespace _11032022
{
    internal class Notebook:Product
    {
        public Notebook(int count,double price,string model):base(count,price)
        {
            this.Model = model;
        }

        public string Brand;
        public string Model;
        public int RAM;
        public int Storage;

        public string GetInfo()
        {
            return $"Brand: {this.Brand} - Model: {this.Model} - Price: {this.Price} \n Count: {this.Count} - RAM: {this.RAM} - Storage: {this.Storage}";
        }
    }
}
