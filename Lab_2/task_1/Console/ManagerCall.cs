using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class ManagerCall : SubscriptionFactory
    {
        public override Subscription CreateSubscription()
        {
            return new EducationalSubscription(); // можна вибирати будь-який тип підписки
        }
    }
}
