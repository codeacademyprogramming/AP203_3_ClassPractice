using System;

namespace _11032022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lengthStr;
            int length;
            do
            {
                Console.WriteLine("Notebook sayini daxil edin:");
                lengthStr = Console.ReadLine();
                length = Convert.ToInt32(lengthStr);

            } while (length < 0);

            Notebook[] notebooks = new Notebook[length];

            for (int i = 0; i < length; i++)
            {
                int count = GetinputInt($"{i + 1}. notebookun sayi:", 1000, 0);

                double price = GetinputDouble($"{i + 1}. notebookun qiymeti:", double.MaxValue, 0);

                string model = GetInputStr($"{i + 1}. notebookun modeli:", 30, 3);

                string brand = GetInputStr($"{i + 1}. notebookun brand:", 500, 2);

                int ram = GetinputInt($"{i + 1}. notebookun RAM deyeri:", 128, 0);

                int storage = GetinputInt($"{i + 1}. notebookun storage deyeri:", int.MaxValue, 0);

                notebooks[i] = new Notebook(count, price, model)
                {
                    Brand = brand,
                    RAM = ram,
                    Storage = storage,
                };
            }

            Console.WriteLine("\n================================\n");
            Console.WriteLine("Notebooks:");

            for (int i = 0; i < notebooks.Length; i++)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine($"{i+1}.ci notebook: ");
                Console.WriteLine(notebooks[i].GetInfo());
            }
        }

        static string GetInputStr(string name,int max,int min)
        {
            string input;
            do
            {
                Console.WriteLine(name);
                input = Console.ReadLine();

            } while (input.Length<min || input.Length>max);

            return input;
        }

        static int GetinputInt(string name,int max,int min)
        {
            int input;
            string inputStr;

            do
            {
                Console.WriteLine(name);
                inputStr = Console.ReadLine();
                input = Convert.ToInt32(inputStr);

            } while (input<min || input>max);

            return input;
        }

        static double GetinputDouble(string name, double max, double min)
        {
            double input;
            string inputStr;

            do
            {
                Console.WriteLine(name);
                inputStr = Console.ReadLine();
                input = Convert.ToDouble(inputStr);

            } while (input < min || input > max);

            return input;
        }
    }
}
