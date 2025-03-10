using SubscriptionFactoryProject.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionFactoryProject.Creators
{
    public class MobileApp : ISubscriptionCreator
    {
        public Subscription CreateSubscription(string type)
        {
            return type switch
            {
                "Domestic" => new DomesticSubscription(),
                "Educational" => new EducationalSubscription(),
                "Premium" => new PremiumSubscription(),
                _ => throw new ArgumentException("Invalid subscription type")
            };
        }
    }
}