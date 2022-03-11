using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[10];

            products[0] = new Product("Macbook 13", "Apple", 3500);
            products[1] = new Product("Macbook 15", "Apple", 5500);
            products[2] = new Product("Macbook 14", "Apple", 4500);
            products[3] = new Product("Macbook 16", "Apple", 6500);
            products[4] = new Product("Iphone 12", "Apple", 1500);
            products[5] = new Product("Iphone 13", "Apple", 2500);
            products[6] = new Product("Iphone 14", "Apple", 4000);
            products[7] = new Product("Iphone 11", "Apple", 1000);
            products[8] = new Product("Iphone X", "Apple", 1200);
            products[9] = new Product("Iphone XS", "Apple", 1350);

            Console.WriteLine("All products:");
            foreach (var item in products)
            {
                Console.WriteLine(item.GetInfo());
            }

            var filteredProducts = FilterByPrice(products, 4000, 6500);

            Console.WriteLine("Filtered products:");
            foreach (var item in filteredProducts)
            {
                Console.WriteLine(item.GetInfo());
            }

        }

        static Product[] FilterByPrice(Product[] products,double minPrice,double maxPrice)
        {
            Product[] filteredProducts = new Product[products.Length];
            int count = 0;


            for (int i = 0; i < products.Length; i++)
            {
                if(products[i].Price>=minPrice && products[i].Price <= maxPrice)
                {
                    filteredProducts[count] = products[i];
                    count++;
                }
            }

            Product[] newFilteredProducts = new Product[count];

            for (int i = 0; i < count; i++)
            {
                newFilteredProducts[i] = filteredProducts[i];
            }

            return newFilteredProducts;
        }


    }
}
