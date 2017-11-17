using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ma valin välja ühe suvalise numbri vahemikus [1 – 100]. Proovi see ära arvata");
            Console.Write("Sisesta Number: ");
            string input = Console.ReadLine();
            int input1 = int.Parse(input);
            int maagilineNumber = 50;


            if (maagilineNumber > input1)
            {
                Console.WriteLine("Arvuti valitud number on Suurem");
            }
            if (maagilineNumber < input1)
            {
                Console.WriteLine("Arvuti Valitud number on Väiksem");
            }
                
            





            Console.ReadLine();

        }
    }
}
