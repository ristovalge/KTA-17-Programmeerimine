using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_First_User_Input
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hei! Tahan meelde jätta kasutaja sisendit");

            string input = Console.ReadLine();

            Console.WriteLine(input);
            Console.WriteLine();
            //Console.ReadLine();
            Console.WriteLine("Midagi veel ilusat siia!");

            string pin = Console.ReadLine();
            Console.WriteLine("Anna oma pin kood!");
            Console.WriteLine("Sinu pin kood on siis selline " + pin);
            Console.ReadLine();



        }
    }
}
