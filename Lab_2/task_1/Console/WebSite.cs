using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class WebSite : SubscriptionFactory
    {
        public override Subscription CreateSubscription()
        {
            return new DomesticSubscription(); // можна вибирати будь-який тип підписки
        }
    }
}
