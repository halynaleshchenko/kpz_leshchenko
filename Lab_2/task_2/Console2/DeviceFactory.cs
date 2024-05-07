using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2
{
    abstract class DeviceFactory
    {
        public abstract Device CreateLaptop();
        public abstract Device CreateSmartphone();
    }
}
