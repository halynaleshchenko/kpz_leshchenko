using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2
{
    class Laptop : Device
    {
        private readonly string brand;

        public Laptop(string brand)
        {
            this.brand = brand;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Laptop from {brand}");
        }
    }
}
