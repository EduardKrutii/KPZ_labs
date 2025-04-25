using ChainOfResponsibility;

class Program
{
    static void Main()
    {
        var menu = new SupportMenu();
        menu.Start();
    }
}