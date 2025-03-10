using SubscriptionFactoryProject.Creators;
using SubscriptionFactoryProject.Subscriptions;

class Program
{
    static void Main()
    {
        ISubscriptionCreator website = new WebSite();
        ISubscriptionCreator mobileApp = new MobileApp();
        ISubscriptionCreator managerCall = new ManagerCall();

        Subscription sub1 = website.CreateSubscription("Domestic");
        Subscription sub2 = mobileApp.CreateSubscription("Premium");
        Subscription sub3 = managerCall.CreateSubscription("Educational");

        Console.WriteLine(sub1);
        Console.WriteLine(sub2);
        Console.WriteLine(sub3);
    }
}
