using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2
{
    class GalaxyFactory : DeviceFactory
    {
        public override Device CreateLaptop()
        {
            return new Laptop("Galaxy");
        }

        public override Device CreateSmartphone()
        {
            return new Smartphone("Galaxy");
        }
    }
}
