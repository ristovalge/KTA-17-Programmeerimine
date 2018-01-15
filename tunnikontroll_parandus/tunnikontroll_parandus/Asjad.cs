using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tunnikontroll_parandus
{
    public class Asjad
    {



        List<string> text = new List<string>();



  
        private Random rng = new Random();

        

        public void Start()
        {
            Console.WriteLine("Programm mis lubab sisestada N+1 hulga erinevaid sõnu, kuni sisestatakse -1");
            Console.WriteLine();

            for (int i = 0; i < 100; i++)
            {
                Console.Write("Sisesta sõna:");
                string asi = Console.ReadLine();
                text.Add(asi);

                if (asi == "-1")
                {
                    break;
                }
 


            }
            Console.WriteLine();
            string joined = string.Join<string>(",", text);
            Console.Write("Sisestasid sõnad: ");
            Console.WriteLine(joined);

            Console.WriteLine();


            int proov = rng.Next(text.Count);
            Console.Write("Suvaline number listist: ");
            Console.WriteLine((string)text[proov]);
        
            Console.WriteLine();
            Console.ReadLine();

          
          
       
            

        }


    }
}
