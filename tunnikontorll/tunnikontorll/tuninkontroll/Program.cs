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
            var number = 0;
            var kala = 0;

            Console.WriteLine("Taco Palenque");
            Console.WriteLine("1200 Maion ST.");
            Console.WriteLine("------------------------------------------------------------");
            
                ;
            while (true)
            {
                int summa = int.Parse(Console.ReadLine());

                
              

                if (summa != -1 )
                {
                    Console.WriteLine("Enter price of food item [-1 to quit]:" + summa);
                }

                if (summa == -1)
                {
                   Console.WriteLine("Enter price of food item [-1 to quit]:" + summa);
                    break;
                }

                
               

                Console.WriteLine();
            }



            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine();





            Console.WriteLine("Subtotal: " + kala);
            Console.WriteLine("15.00 % Gratuity: ");
            Console.WriteLine("Total: ");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
