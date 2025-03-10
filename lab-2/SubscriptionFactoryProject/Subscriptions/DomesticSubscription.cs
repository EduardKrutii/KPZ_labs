using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionFactoryProject.Subscriptions
{
    public class DomesticSubscription : Subscription
    {
        public DomesticSubscription() : base("Domestic", 9.99m, 6, new List<string> { "Basic Channels", "HD Available" }) { }
    }
}