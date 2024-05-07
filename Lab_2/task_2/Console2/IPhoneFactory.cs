using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2
{
    class IPhoneFactory : DeviceFactory
    {
        public override Device CreateLaptop()
        {
            return new Laptop("IPhone");
        }

        public override Device CreateSmartphone()
        {
            return new Smartphone("IPhone");
        }
    }
}
