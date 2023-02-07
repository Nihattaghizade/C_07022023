using System;

namespace _07022023home
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var nt1 = new Notebook("Asus", "Rog", 1200, 16);

            Console.WriteLine("Notebook count:");
            int count = Convert.ToInt32(Console.ReadLine());

            Notebook[] notebooks = new Notebook[count];

           for (int i = 0; i < count; i++)
            {
                Console.Write("Brand: ");
                string brand = Console.ReadLine();
                Console.Write("Model: ");
                string model = Console.ReadLine();
                Console.Write("Price: ");
                double price = Convert.ToDouble(Console.ReadLine());
                Console.Write("RAM: ");
                int ram = Convert.ToInt32(Console.ReadLine());

                Notebook nt = new Notebook(brand, model) { Price = price, RAM = ram };
                notebooks[i] = nt;
            }

            double sum = 0;
            for (int i = 0; i < notebooks.Length; i++)
            {
                sum += notebooks[i].Price;
            }

            var result = sum / notebooks.Length;
            Console.WriteLine(result);

        }
    }
}
