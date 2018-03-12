using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar01Cipher
{
    public class Decrypting
    {


        public void midagi()
        {

            Console.Write("Palun sisesta siia krüptiud tekst: ");
            string text = Console.ReadLine();
            string encrypted_text = text;
            string decoded_text = " ";
            int shift = 0;
            char character = '0';
            encrypted_text = encrypted_text.ToUpper();

            char[] alphabet = new char[30] { 'Z', 'Y', 'X', 'Ü', 'Ö', 'Ä', 'Õ', 'W', 'V', 'U', 'T', 'S', 'R', 'Q', 'P', 'O', 'N', 'M', 'L', 'K', 'J', 'I', 'H', 'G', 'F', 'E', 'D', 'C', 'B', 'A' };

            Console.WriteLine("The encrypted text is \n{0}", encrypted_text);

            Console.Write("Sisesta nihke suurus: ");
            string kysi = Console.ReadLine();
            int arv = int.Parse(kysi);



            for (int i = arv; i < arv + 1; i++)
            {
                decoded_text = "";
                foreach (char c in encrypted_text)
                {
                    character = c;

                    if (character == '\'' || character == ' ')
                        continue;

                    shift = Array.IndexOf(alphabet, character) + i;
                    if (shift <= 0)
                        shift = shift + arv;

                    if (shift >= 30)
                        shift = shift - 30;


                    decoded_text += alphabet[shift];
                }
                Console.WriteLine("\nKrüpteeritud kood on :  {0} ", decoded_text);
            }
        }

    }
}

