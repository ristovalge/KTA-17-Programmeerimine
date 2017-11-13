using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6by6MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------");
            // print out 6b6 multiplication table using to nested loops.
            Console.WriteLine($"X\t0\t1\t2\t3\t4\t5\t6\t");

            for (int i = 1; i < 7; i++)
            //Console.WriteLine($"| {i} | 0 | 1 | 2 | 3 | 4 | 5 | 6 |");
            {

                for (int j = 1; j < 7; j++)
                {

                    Console.Write(i * j + "\t");


                }
                Console.Write("\n");
            }





            Console.WriteLine("--------------------------------------------------------------");

            Console.ReadKey();

        }
    }
}
