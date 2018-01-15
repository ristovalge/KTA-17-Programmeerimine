using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    class Program
    {
        static void Main(string[] args)
        {


            HangManGame game = new HangManGame();
            game.Play();



           









            //Tahed tahed = new Tahed();


            Sonad sonad = new Sonad(); 

            //Console.WriteLine("\nSee on Hangman mäng \nSul on 5 eksimisvõimalust!");
            //Console.Write("Sisesta üks täht tähestikust: ");


            //string tahed2 = Console.ReadLine();
            //tahed.ToString();

            sonad.Add("Hobune");
            sonad.Add("Koer");
            sonad.Add("Lennuk");
            sonad.Add("kukeseen");
            sonad.Add("Tallinn");

            //Console.WriteLine();
            Console.ReadLine();








        }
    }
}
