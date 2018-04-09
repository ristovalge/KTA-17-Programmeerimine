using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valmistumine_eksamix
{
    class Program
    {
        static void Main(string[] args)
        {
            string nimi = "";



            ArrayList myList = new ArrayList();
            string input = "";

            do
            {
                Console.Write("Sisesta nimi ja vajuta enter:");
                input = Console.ReadLine();
                if (input == "-1")
                    break;
                else
                    myList.Add(input);
            } while (true);
            Console.Clear();


            foreach (var item in myList)
            {
                Console.WriteLine(UppercaseFirst(item.ToString()));
            }
            Console.ReadLine();




            string UppercaseFirst(string s)
            {
                if (string.IsNullOrEmpty(s))
                {
                    return string.Empty;
                }
                nimi = nimi.ToLower();
                char[] a = s.ToCharArray();
                a[0] = char.ToUpper(a[0]);
                return new string(a);
            }


        }
    }
}