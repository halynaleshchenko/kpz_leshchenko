using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class DomesticSubscription : Subscription
    {
        public DomesticSubscription() : base(10.99m, 1, new List<string> { "General", "Entertainment" }) { }
    }
}
