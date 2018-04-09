using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YL3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sisesta minimaalne aasta arv: ");
            string minAastaString = Console.ReadLine();
            int minAasta = int.Parse(minAastaString);

            Console.Write("Sisesta maximaalne aasta arv: ");
            string maxAastaString = Console.ReadLine();
            int maxAasta = int.Parse(maxAastaString);

            Console.Write("Sisesta suvaliselt gernereeritavate andmete hulk: ");
            string suvalineAndmeString = Console.ReadLine();
            int suvalineAmded = int.Parse(suvalineAndmeString);



            List<DateTime> randomTimes = new List<DateTime>();
            Random r = new Random();
            DateTime start = new DateTime(minAasta, 1, 7, 0, 0, 0);
            DateTime end = new DateTime(maxAasta, 12, 31, 23, 59, 59);
            int range = (end - start).Days;

            for (var i = 0; i < suvalineAmded; i++)
            {
                int rnd = r.Next(1, range);
                var genTime = start.AddDays(rnd);
                randomTimes.Add(genTime);
            }

            Console.WriteLine();
            for (var i = 0; i < randomTimes.Count; i++)
            {
                Console.WriteLine(randomTimes[i].ToShortDateString());
            }
            Console.ReadKey();
   

            randomTimes.Sort();
        }
    }
}
