using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar01Cipher
{
    public class OOPCrypt
    {
        private char[] alphabet = new char[30] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'Õ', 'Ä', 'Ö', 'Ü', 'X', 'Y', 'Z' };
        private char[] alphabet1 = new char[30] { 'Z', 'Y', 'X', 'Ü', 'Ö', 'Ä', 'Õ', 'W', 'V', 'U', 'T', 'S', 'R', 'Q', 'P', 'O', 'N', 'M', 'L', 'K', 'J', 'I', 'H', 'G', 'F', 'E', 'D', 'C', 'B', 'A' };
        private char character = '0';
        private string decoded_text = " ";
        private int shift = 0;

        public string read()
        {
            string text = Console.ReadLine();
            string encrypted_text = text;
            encrypted_text = encrypted_text.ToUpper();
            return encrypted_text;
        }
        public string vahetext(string v)
        {
            string usin = "Palun sisesta siia " + v + " tekst: ";
            return usin;
        }

        public int Nihe()
        {
            Console.Write("Sisesta nihke suurus: ");
            string kysi = Console.ReadLine();
            int arv = int.Parse(kysi);
            return arv;
        }

        public string Uuu(int v, string a, char[] b)
        {
            for (int i = v; i < v + 1; i++)
            {
                decoded_text = "";
                foreach (char c in a)
                {
                    character = c;

                    if (character == '\'' || character == ' ')
                        continue;

                    shift = Array.IndexOf(b, character) + i;
                    if (shift <= 0)
                        shift = shift + v;

                    if (shift >= 30)
                        shift = shift - 30;
                    decoded_text += b[shift];                  
                }                
            }
            return decoded_text;
        }

        public string decrypt()
        {
            string asi = vahetext("dekrüpteeritud");
            Console.Write(asi);
            string sona = read();
            int arv = Nihe();
            var jee = Uuu(arv,  sona, alphabet1);
            return jee;
        }



        public void crypt()
        {
            string asi = vahetext("krüpteeritud");
            Console.Write(asi);
            string sona = read();
            int arv = Nihe();
            var jee = Uuu(arv, sona, alphabet);
            Console.WriteLine("The encrypted text is \n{0}", jee);           

        }
    }
}
