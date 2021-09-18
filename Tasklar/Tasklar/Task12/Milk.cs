using System;
using System.Collections.Generic;
using System.Text;

namespace Tasklar.Task12
{
    class Milk : Product
    {
        public double Volume;
        public double Fatrate;

        public Milk(string name, double price, int count, double volume, double fatrate) : base(name,price,count)
        {
            Volume = volume;
            Fatrate = fatrate;

        }
    }
}
