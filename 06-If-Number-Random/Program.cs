using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_If_Number_Random
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Kas number on suurem või väiksem");

            int number = 5;

            Console.WriteLine();
            Console.Write("kasutaja sisestab numbri: ");
            
            string suva = Console.ReadLine();
            Console.WriteLine();

            int suva1 = int.Parse(suva);
             if(number < suva1  )
            {
                Console.WriteLine("Number on Väiksem ");
            }

             if (number > suva1)
            {
                Console.WriteLine("Number on Suurem ");
            }

            if (number == suva1)
            {
                Console.WriteLine($"Bingo sa valisid numbriks: {suva}  ");
                Console.WriteLine();
            }

            Console.WriteLine("Press any key to continue ");
            Console.ReadLine();

        }
    }
}
