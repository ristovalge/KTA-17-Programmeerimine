using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar01Cipher
{
    class Program
    {
        public static void Main()
        {

            Console.WriteLine("Oled sattunud Caesar shiffri programmile!");
            Console.WriteLine("Kui soovid Krüptida oma sõna vali nr. C");
            Console.WriteLine("Kui soovid Dekrüptida oma sõna vali nr. D");
            Console.WriteLine("Sisesta palun oma valik: ");
            Console.WriteLine();


            while (true)
            {
                ConsoleKeyInfo currentKey = Console.ReadKey(true);
                switch (currentKey.Key)
                {
                    case ConsoleKey.C:

                        if (true)
                        {
                            OOPCrypt crypt = new OOPCrypt();
                            crypt.crypt();
                        }
                        break;
                    case ConsoleKey.D:

                        if (true)
                        {
                            OOPCrypt decrypt = new OOPCrypt();
                            string tulem= decrypt.decrypt();
                            Console.WriteLine("The encrypted text is \n{0}", tulem);
                        }
                        break;

                    default:

                        Console.WriteLine("Palun sisesta Õige täht Sisestasid: {0}", currentKey.Key);
                        break;

                }
                Console.WriteLine("Sisesta palun oma uus valik: ");
            }       


        }

    }
}
