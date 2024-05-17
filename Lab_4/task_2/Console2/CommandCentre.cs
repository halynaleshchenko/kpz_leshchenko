using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2
{
    class CommandCentre
    {
        private List<Runway> _runways;
        private List<Aircraft> _aircrafts;

        public CommandCentre(List<Runway> runways, List<Aircraft> aircrafts)
        {
            _runways = runways;
            _aircrafts = aircrafts;
        }

        public bool CanLand(Runway runway)
        {
            return runway.IsAvailable();
        }

        public void NotifyLanding(Aircraft aircraft, Runway runway)
        {
            runway.Land(aircraft);
        }

        public void NotifyTakeOff(Aircraft aircraft, Runway runway)
        {
            runway.TakeOff(aircraft);
        }
    }
}
