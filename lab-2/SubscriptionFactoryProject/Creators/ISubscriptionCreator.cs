using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubscriptionFactoryProject.Subscriptions;

namespace SubscriptionFactoryProject.Creators
{
    public interface ISubscriptionCreator
    {
        Subscription CreateSubscription(string type);
    }
}