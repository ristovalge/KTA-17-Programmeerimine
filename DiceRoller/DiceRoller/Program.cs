using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    public class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int  sum = 0;
            int value2 = 0;

            Console.WriteLine("> /roll 3d6 2d8");
            Console.WriteLine();
            Console.WriteLine();

            Dice uus = new Dice();
            

            for (int i = 0; i < 3; i++)
            {

                //var roll = rnd.Next(1, 7);
                int roll= uus.Roll(6);
                Console.WriteLine("1d6: {0}", roll);

               
                sum += roll;
            }
            for (int j = 0; j < 2; j++)
            {

               int roll= uus.Roll(8);
                Console.WriteLine("1d8: {0}", roll);
                sum += roll;
            }
            //Console.WriteLine("1d6: {0}", rnd.Next(1, 7));
            //Console.WriteLine("1d6: {0}", rnd.Next(1, 7));
            //Console.WriteLine("1d6: {0}", rnd.Next(1, 7)); 
            //Console.WriteLine("1d8: {0}", rnd.Next(1, 9));
            //Console.WriteLine("1d8: {0}", rnd.Next(1, 9));

            Console.WriteLine();
            Console.WriteLine("Roll total: {0}",sum );
            Console.WriteLine();
            Console.WriteLine(">");
            Console.WriteLine();




            Console.ReadLine();


        }
    }
}
