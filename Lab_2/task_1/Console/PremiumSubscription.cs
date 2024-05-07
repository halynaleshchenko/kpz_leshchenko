using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class PremiumSubscription : Subscription
    {
        public PremiumSubscription() : base(25.99m, 12, new List<string> { "General", "Entertainment", "Sports", "Movies" }) { }
    }
}
