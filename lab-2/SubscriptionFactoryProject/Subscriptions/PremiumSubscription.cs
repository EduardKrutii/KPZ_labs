using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionFactoryProject.Subscriptions
{
    public class PremiumSubscription : Subscription
    {
        public PremiumSubscription() : base("Premium", 19.99m, 12, new List<string> { "All Channels", "4K Streaming", "Exclusive Content" }) { }
    }
}