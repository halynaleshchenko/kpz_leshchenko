using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2
{
    class Runway
    {
        public bool IsBusy { get; private set; }

        public bool IsAvailable()
        {
            return !IsBusy;
        }

        public void Land(Aircraft aircraft)
        {
            Console.WriteLine($"Aircraft {aircraft.Name} is landing on runway.");
            IsBusy = true;
            Console.WriteLine($"Runway is now busy.");
        }

        public void TakeOff(Aircraft aircraft)
        {
            Console.WriteLine($"Aircraft {aircraft.Name} is taking off from runway.");
            IsBusy = false;
            Console.WriteLine($"Runway is now free.");
        }
    }
}
