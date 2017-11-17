using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace tuninkontroll
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double total = 0;



            Console.WriteLine("Taco Palenque");
            Console.WriteLine("1200 Maion ST.");
            Console.WriteLine("------------------------------------------------------------");
           

            while (true)
            {

                Console.Write("Enter price of food item [-1 to quit]: ");
                string summa = Console.ReadLine();
               
               Double value = double.Parse(summa);
                

                if (value  == -1 )
                {
                    break;
                    
                     
                }

                total = total + value;


            }
             double pros = 0.15 * total;

            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine();





            Console.WriteLine($"Subtotal: € {(total):F2}" );
            Console.WriteLine($"15.00 % Gratuity: € {(pros):f2}" );
            Console.WriteLine($"Total: € {(total - pros):F2}" );
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
