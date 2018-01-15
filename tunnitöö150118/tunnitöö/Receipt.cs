using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tunnitöö
{
  public  class Receipt
    {

        public void Start()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            double total = 0;
            double pros = 0;

            Console.WriteLine("Taco Palenque \n1200 Main ST. ");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------------");

            while (true)
            {
           Console.Write("Enter price of food item [-1 to quit]:");
                string summa = Console.ReadLine();
                Double value = double.Parse(summa);
            
            if (summa == "-1")
            {
                break;
            }

                total = total + value;
                pros = total * 0.15;

            }
 
            

            Console.WriteLine("-------------------------------------------------------------------------------");

            Console.WriteLine("Subtotal: € {0} ", total,2);
            Console.WriteLine("15.00 % Gratuity: € {0:F2} ", pros);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Total:€ {0:F2}", (total+pros) );
            Console.ResetColor();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();


        }


    }
}
