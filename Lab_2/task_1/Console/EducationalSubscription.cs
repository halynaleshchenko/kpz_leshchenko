using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class EducationalSubscription : Subscription
    {
        public EducationalSubscription() : base(15.99m, 6, new List<string> { "Educational", "Documentary" }) { }
    }
}
