using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPTpank1
{
    class Program
    {
        /* See võiks olla programm sisenemiseks panga kontole. Alguses palutakse kasutajal registreerida ja siis küsitakse kasutajalt panka sisenemiseks 
         * pin koodi. Sisestades õige koodi kuvatalse kasutaja nimi suuret tähtedega. Sisestada saab ainult numbreid parooliks ning parooli
         * pikkus peab olema 4 numbrit.
         */
        static void Main(string[] args)
        {
            

            Console.WriteLine("Registreeru Meie Panka: ");
            Console.WriteLine();

            Console.WriteLine("Sisesta oma eesnimi ja pin koood");
            Console.WriteLine();
            Console.Write("Sisesta palun oma Eesnimi : ");

            string eesnimi = Console.ReadLine();
            
            Console.Write("Sisesta oma PIN kood (neli numbrit): ");
            bool number1  = false;
            string number = null;
            while (!number1)
            {
                 number = Console.ReadLine();
                
                
                if (number.Length != 4  || System.Text.RegularExpressions.Regex.IsMatch(number,@"^[a-zA-Z]+$")  )

                {
                    Console.Write("VIGA!!! Palun sisesta 4 numbrit: ");
                    
                }
                else
                {
                    
                    break;

                }
            }

            Console.WriteLine(number1);
            Console.Clear();
            Console.WriteLine("Palun sisesta PIN kood sienemaks oma kontole : ");
            Console.WriteLine();



            bool valepin = false;
            

            while (!valepin)
            {

                Console.Write("Sisesta Oma PIN Kood: ");
                String pin = Console.ReadLine();
                //int pin1 = int.Parse(pin);
                Console.WriteLine();
                    


                if (pin != number || System.Text.RegularExpressions.Regex.IsMatch(number, @"^[a-zA-Z]+$"))
                {
                    Console.WriteLine("Oled sisestanud vale koodi, proovi uuesti!");
                    Console.WriteLine();
                }
                
                   
                



                else
                {
                    valepin = true;
                    Console.Clear();
                    Console.WriteLine();
                    Console.Write("Teretulemast meie panka  \n \n");
                    Console.Write("kasutaja  :  ");
                    Console.WriteLine(eesnimi.ToUpper());
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Kontol oleva summa loodeteavasti avaldame järgmistes kodutöödes. \n \nKannatust! ;) \n \n \nVäljumiseks vajuta suvalist nuppu  ");



                }
            }



            //Console.ReadLine();
            Console.ReadKey();






        }
    }
}