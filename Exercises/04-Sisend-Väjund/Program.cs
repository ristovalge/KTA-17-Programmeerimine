using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Sisend_Väjund
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mina olen papgoi programm. Ütle mulle midagi ja ma kordan selle Sulle tagasi...");
            Console.WriteLine();
            
            Console.Write("Sina ütled:");
            string papa = Console.ReadLine();
            Console.WriteLine("Mina ütlen:" + papa);
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();

        }
    }
}
