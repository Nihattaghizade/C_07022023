using System;
using System.Collections.Generic;
using System.Text;

namespace _07022023home
{
    internal class Notebook
    {

        public Notebook(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        public Notebook(string brand, string model, double price) : this(brand, model)
        {
            Price = price;
        }

        public Notebook(string brand, string model, double price, int ram) : this(brand, model, price)
        {
            RAM = ram;
        }

        public string Brand;
        public string Model;
        public double Price;
        public int RAM = 4;


        public void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand} - Model: {Model} - Price: {Price}");
        }

    }
}
