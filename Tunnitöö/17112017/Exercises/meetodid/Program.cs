using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meetodid
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "risto";
            string juhuu = "sisalik";
            int masin = 5;
            PrintGreeting(name, 5, juhuu, masin);
            Console.WriteLine("WTF");
           GetUserInput();
            Mina();

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        static void PrintGreeting(string name1, int b3, string xzxz, int masin)
        {
            Console.WriteLine("juhuu");
            Console.WriteLine($"ei ütle {name1}");
            Console.WriteLine($"ei ütle {b3}");
            Console.WriteLine($"ei ütle {xzxz}");
        }
        static void DoSomething()
        {

        }
        static int GetUserInput()
        {
            string input = Console.ReadLine();

            int value = 0;
            bool success = int.TryParse(input, out value);
            return value;

        }

        static void Mina()
        {


        }
        

        
        

        
    }
}
