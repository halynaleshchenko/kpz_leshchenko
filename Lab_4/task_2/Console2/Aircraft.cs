using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2
{
    class Aircraft
    {
        public string Name { get; }
        private CommandCentre _commandCentre;

        public Aircraft(string name, CommandCentre commandCentre)
        {
            Name = name;
            _commandCentre = commandCentre; // Initialize the _commandCentre field
        }

        public void RequestToLand(Runway runway)
        {
            Console.WriteLine($"Aircraft {Name} requests to land.");
            if (_commandCentre.CanLand(runway))
            {
                _commandCentre.NotifyLanding(this, runway);
            }
            else
            {
                Console.WriteLine($"Could not land, all runways are busy.");
            }
        }

        public void RequestTakeOff(Runway runway)
        {
            Console.WriteLine($"Aircraft {Name} requests to take off.");
            _commandCentre.NotifyTakeOff(this, runway);
        }
    }
}
