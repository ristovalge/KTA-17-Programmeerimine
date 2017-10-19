using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Parse_Input_Multiply_Divide
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Mina olen kalkulaator programm. Ütle mulle 2 numbrit ja mina ütlen Sulle nende korrutise ja jagatise ");
            Console.WriteLine();
            Console.Write("Esimene number: ");
            string esimene = Console.ReadLine();
            Console.Write("Teine number: ");
            string teine = Console.ReadLine();
            Console.WriteLine();

            int NumbriksEsimene = int.Parse(esimene);
            int NumbrikstTeine = int.Parse(teine);

            Console.Write($"Korrutates : {esimene} ja {teine} on tulemuseks: ");
            Console.WriteLine(NumbriksEsimene * NumbrikstTeine);
            Console.Write("Jagades : " + esimene +" ja " + teine+ " on tulemuseks: ");
            Console.WriteLine(NumbriksEsimene / NumbrikstTeine);
            Console.WriteLine();



            Console.WriteLine("Press any key to continue ");
            Console.ReadLine();

        }
    }
}
