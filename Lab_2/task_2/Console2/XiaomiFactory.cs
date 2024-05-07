using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2
{
    class XiaomiFactory : DeviceFactory
    {
        public override Device CreateLaptop()
        {
            return new Laptop("Xiaomi");
        }

        public override Device CreateSmartphone()
        {
            return new Smartphone("Xiaomi");
        }
    }
}
