using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class MobileApp : SubscriptionFactory
    {
        public override Subscription CreateSubscription()
        {
            return new PremiumSubscription(); // можна вибирати будь-який тип підписки
        }
    }
}
