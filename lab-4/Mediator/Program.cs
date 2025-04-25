using Mediator;

class Program
{
    static void Main()
    {
        var runway1 = new Runway();
        var runway2 = new Runway();

        var commandCentre = new CommandCentre(new[] { runway1, runway2 });

        var aircraft1 = new Aircraft("Boeing-737", commandCentre);
        var aircraft2 = new Aircraft("Airbus-A320", commandCentre);

        aircraft1.RequestLanding();
        aircraft2.RequestLanding();

        aircraft1.RequestTakeOff();
        aircraft2.RequestTakeOff();

        aircraft2.RequestLanding();
    }
}