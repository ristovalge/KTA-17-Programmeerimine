using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tunnikontorll
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("See on allahindluse arvutamise programm, sisesta summa: ");
            Console.WriteLine();

            int summa = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int ans = 0;

            bool hind =false;
            while (!hind)
            {
                if (summa >= 50)
                {
                    Console.Write("Tavakliendi hind on ", (ans = (summa) - ((summa * 10) / 100)));
                    Console.WriteLine(ans);
                    Console.Write("Püsikliendi hind on ", (ans = (summa) - ((summa * 20) / 100)));
                    Console.WriteLine(ans);

                    break;
                    if (summa >= 250)
                    {
                        Console.Write("Tavakliendi hind on ", (ans = (summa) - ((summa * 20) / 100)));
                        Console.WriteLine(ans);
                        Console.Write("Püsikliendi hind on ", (ans = (summa) - ((summa * 30) / 100)));
                        Console.WriteLine(ans);

                        break;
                        if (summa >= 350)
                        {
                            Console.Write("Tavakliendi hind on ", (ans = (summa) - ((summa * 30) / 100)));
                            Console.WriteLine(ans);
                            Console.Write("Püsikliendi hind on ", (ans = (summa) - ((summa * 40) / 100)));
                            Console.WriteLine(ans);

                            break;
                        }
                        else
                        {
                            Console.WriteLine("eee");
                        }

                    }
                }

            }
            Console.ReadKey();
        }
    }


}
