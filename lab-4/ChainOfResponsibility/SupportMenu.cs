using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainOfResponsibility.Handlers;

namespace ChainOfResponsibility
{
    public class SupportMenu
    {
        private readonly SupportHandler _handlerChain;

        public SupportMenu()
        {
            var level1 = new Level1Support();
            var level2 = new Level2Support();
            var level3 = new Level3Support();
            var defaultHandler = new DefaultSupport();

            level1.SetNext(level2);
            level2.SetNext(level3);
            level3.SetNext(defaultHandler);

            _handlerChain = level1;
        }

        public void Start()
        {
            bool handled = false;

            while (!handled)
            {
                Console.WriteLine("Welcome to Support System!");
                Console.WriteLine("Select your issue:");
                Console.WriteLine("1 - Password Reset");
                Console.WriteLine("2 - Payment Issue");
                Console.WriteLine("3 - Technical Problem");
                Console.WriteLine("Any other key - Unknown Issue");

                string input = Console.ReadLine() ?? "";
                var request = new SupportRequest(input);

                handled = _handlerChain.Handle(request);
                if (!handled)
                {
                    Console.WriteLine("Restarting menu...\n");
                }
            }
        }
    }
}