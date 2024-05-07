using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    abstract class SubscriptionFactory
    {
        public abstract Subscription CreateSubscription();
    }
}
