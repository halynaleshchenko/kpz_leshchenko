using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2
{
    class Program
    {
        static void Main(string[] args)
        {
            var runway1 = new Runway();
            var runway2 = new Runway();

            var commandCentre = new CommandCentre(new List<Runway> { runway1, runway2 }, new List<Aircraft>());

            var aircraft1 = new Aircraft("Aircraft 1", commandCentre);
            var aircraft2 = new Aircraft("Aircraft 2", commandCentre);

            aircraft1.RequestToLand(runway1);
            aircraft2.RequestToLand(runway2);
            aircraft1.RequestTakeOff(runway1);
            aircraft2.RequestTakeOff(runway2);
        }
    }
}
