using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2
{
    class Smartphone : Device
    {
        private readonly string brand;

        public Smartphone(string brand)
        {
            this.brand = brand;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Smartphone from {brand}");
        }
    }
}
