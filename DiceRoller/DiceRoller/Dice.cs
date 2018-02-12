using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class Dice
    {

        public int Roll(int sides)
        {

            Random rnd = new Random();


                

            return rnd.Next(1, sides +1);
        }
        
    }
}