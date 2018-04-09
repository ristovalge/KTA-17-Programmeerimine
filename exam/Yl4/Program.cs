using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using System.Threading;

namespace Yl4
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("ee-EE");
            DateTime now = DateTime.Today;

            string[] born =
            {
                "15.01.1977", "20.03.1985","16.08.1940","20.04.2010","14.06.1955","15.06.1977", "20.07.1985","16.03.1940","20.01.2005","14.09.1956","10.04.1977",
                "27.03.1985","19.08.1940","05.04.2010","06.06.1955","17.08.1977",
                "26.08.1985","13.03.1940","27.03.2001","11.10.1954","14.09.1956","20.01.1977", "03.03.1985","04.08.1940","07.04.2010","06.06.1955","02.08.1977",
                "20.07.1955","16.03.1941","20.01.1965","14.09.1976","10.04.1987", "27.03.1995","19.08.1990","05.04.2009","06.06.1995","17.08.1997",
                "26.08.1995","13.03.1950","27.03.2010","11.10.1964","14.09.1966","20.01.1987", "03.03.1995","04.08.1950","07.04.2008","06.06.1966","02.08.1988",
                "26.08.1983","13.03.1966","27.03.2003","11.10.1951","11.10.1952"
            };

            List<DateTime> date = new List<DateTime> { };

            for (int i = 0; i < born.Length; i++)
            {
                var dateString = born.ToString();
                var format = "dd.MM.yyyy";
                var dateTime = DateTime.ParseExact(born[i], format, CultureInfo.InvariantCulture);
             
            
                date.Add(dateTime);
            }

            DateTime[] dateArray = date.ToArray();

            List<int> vanus = new List<int> { };

            foreach (var item in dateArray)
            {
                var vanus1 = now.Year - item.Year;
                vanus.Add(vanus1);
               // Console.WriteLine(vanus1);
            }
            int[] vanuseArray = vanus.ToArray();
            Console.WriteLine($"Maksimaalne vanus: {vanuseArray.Max()}");
            Console.WriteLine();


            double keskmine = Math.Round(vanuseArray.Average(), 0);
            Console.WriteLine($"Keskmine vanus: {keskmine}");
            Console.WriteLine();

           
            Console.WriteLine($"Minimaalne vanus: {vanuseArray.Min()}");
            Console.WriteLine();

            string kuuNimi = "August";

            Console.WriteLine("Keskmine Sünnipäevi kuus on : {0}", kuuNimi);
            Console.WriteLine();

            Array.Sort(dateArray);
            foreach (var item in dateArray)
            {
                Console.WriteLine(item.ToShortDateString());
            }


            Console.WriteLine();
            Console.WriteLine("end programm");
            Console.ReadKey();









        }

  
    }
}
