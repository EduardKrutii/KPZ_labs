using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionFactoryProject.Subscriptions
{
    public abstract class Subscription
    {
        public string Name { get; protected set; }
        public decimal MonthlyFee { get; protected set; }
        public int MinPeriod { get; protected set; }
        public List<string> Features { get; protected set; }

        protected Subscription(string name, decimal monthlyFee, int minPeriod, List<string> features)
        {
            Name = name;
            MonthlyFee = monthlyFee;
            MinPeriod = minPeriod;
            Features = features;
        }

        public override string ToString()
        {
            return $"Subscription: {Name}, Fee: {MonthlyFee:C}, Min Period: {MinPeriod} months, Features: {string.Join(", ", Features)}";
        }
    }
}