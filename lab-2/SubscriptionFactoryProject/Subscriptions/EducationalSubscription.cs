using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionFactoryProject.Subscriptions
{
    public class EducationalSubscription : Subscription
    {
        public EducationalSubscription() : base("Educational", 6.99m, 3, new List<string> { "Educational Channels", "No Ads" }) { }
    }
}