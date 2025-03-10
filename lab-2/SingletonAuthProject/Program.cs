using System;
using System.Threading.Tasks;

namespace SingletonAuthProject
{
    class Program
    {
        static void Main()
        {
            Parallel.Invoke(
                () => PrintAuthenticatorInstance(),
                () => PrintAuthenticatorInstance(),
                () => PrintAuthenticatorInstance()
            );
        }

        static void PrintAuthenticatorInstance()
        {
            Authenticator auth = Authenticator.GetInstance();
            Console.WriteLine($"Authenticator Token: {auth.GetToken()}");
        }
    }
}