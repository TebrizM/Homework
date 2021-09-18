using System;
using System.Collections.Generic;
using System.Text;

namespace Tasklar.Task12
{
    class Product
    {
        public string name;
        public double price;
        public int count;
        public double totalincome;

        public Product(string Name, double Price, int Count)
        {
            name = Name;
            price = Price;
            count = Count;
        }

        public void Sell()
        {
            if(count <= 0)
            {
                Console.WriteLine("Mehsul tukenmishdir:");
                return;
            }
            count--;
            totalincome += price;
        }

    }
}
