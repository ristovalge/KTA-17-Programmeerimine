using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordMixer
{
    class Program
    {
        static void Main(string[] args)
        {








            Console.Write("Sisesta siia oma sõna: ");
            //string word = Console.ReadLine();

            String[] word = Console.ReadLine().Split(' ');


            foreach (String part in word)
            {
                string str = part.Substring(1, part.Length -2);
                char viimane = part[part.Length - 1];
                char esimene = part[0];
                Console.Write("{0}{1}{2} ",esimene, Meetod(str), viimane);
            }




            

            Console.ReadLine();
        }
        static string Meetod(string word)
        {
            string temp = word;
            string result = string.Empty;
            Random rand = new Random();

            for (int a = 0; a < word.Length; a++)
            {
                //multiplied by a number to get a better result, it was less likely for the last index to be picked
                int temp1 = rand.Next(0, (temp.Length - 1) * 3);

                result += temp[temp1 % temp.Length];
                temp = temp.Remove(temp1 % temp.Length, 1);
            }

            return result;
        }

    }

}
