using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    abstract class Subscription
    {
        public decimal MonthlyFee { get; protected set; }
        public int MinimumSubscriptionPeriod { get; protected set; }
        public List<string> AvailableChannels { get; protected set; }

        public Subscription(decimal monthlyFee, int minimumSubscriptionPeriod, List<string> availableChannels)
        {
            MonthlyFee = monthlyFee;
            MinimumSubscriptionPeriod = minimumSubscriptionPeriod;
            AvailableChannels = availableChannels;
        }
    }
}
