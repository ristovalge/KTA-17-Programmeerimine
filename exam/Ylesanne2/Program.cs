using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ylesanne2
{
    class Program
    {
        static void Main(string[] args)
        {

            int milliseconds = 2000;
           
            string[] names = new string[] { "Kaur", "Mattias", "Kristel", "Heleri", "Trevor", "Kristjan", "Kelli",
                "Kevin", "Maarika", "Laura" };

            Console.Write("Sisesta soovitud lause: ");
           
            string input = Console.ReadLine();

            string[] words = input.Split(null);

            foreach (var word in words)
            {
                string firstUpper = char.ToUpper(word[0]) + word.Substring(1);
                if (names.Any(firstUpper.Contains))
                {
                    Console.Write(firstUpper + " ");
                }
                else
                {
                    Console.Write(word + " ");
                }
            }
            Console.WriteLine();
            Thread.Sleep(milliseconds);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Jätkamiseks vajuta midagi ");
            Console.ReadLine();

        }

    }
}
