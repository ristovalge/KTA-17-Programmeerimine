using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ma valin välja ühe suvalise numbri vahemikus [1 – 100]. Proovi see ära arvata");
            Console.WriteLine();

           Random rnd = new Random();
           int maagilineNumber = rnd.Next(1, 100);
            bool correct = false;

            Console.WriteLine();


            
            while (!correct)

            {
                Console.Write("Sisesta number:");
                String input = Console.ReadLine();
                int input1 = int.Parse(input);
                

                Console.WriteLine();

                if (maagilineNumber > input1)
                {
                    Console.WriteLine("Arvuti valitud number on Suurem. Sina sisestasid: " + input1 +". Proovu uuesti!");
                    Console.WriteLine();

                    continue;
                }
                if (maagilineNumber < input1)
                {
                    Console.WriteLine("Arvuti Valitud number on Väiksem. Sina sisestasid" + input1 + ". Proovu uuesti!");
                    Console.WriteLine();


                }
                else 
                {
                    correct = true;
                    Console.WriteLine("Arvasid numbri ära!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! " );
                    Console.WriteLine();

                    



                }

            }
            
                        Console.ReadLine();

        }
    }
}
