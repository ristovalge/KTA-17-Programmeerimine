using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Blackjack
{
    public class Gameplay
    {
        static string[] playerCards = new string[11];
        static string[] playerSuit = new string[4];
        static string hitOrStay = "";
        static string[] dealerCards = new string[11];
        static string[] dealerSuit = new string[4];
        static int playerTotal = 0, count = 1, dealerTotal = 0;
        private string playerName;
        private Random rng;

        public Gameplay()
        {
            rng = new Random();

            playerName = NewGame();

        }





        public void Play()
        {
            Console.WriteLine("Welcome to the game of Blackjack  {0}", playerName);
            Console.WriteLine();


            playerCards[0] = GetPlayerCard();
            playerCards[1] = GetPlayerCard();
            dealerCards[0] = GetComputerDealer();
            dealerCards[1] = GetComputerDealer();
            playerSuit[0] = GetDealerSuit();
            playerSuit[1] = GetDealerSuit();
            dealerSuit[0] = GetDealerSuit();
            dealerSuit[1] = GetDealerSuit();

            int dealerFirstTotal = FirstTotal();

            do
            {

                Console.WriteLine("You have been dealt : {0} of {1} and {2} of {3} ", playerCards[0], playerSuit[0], playerCards[1], playerSuit[1]);
                Console.WriteLine("House has been dealt : {0} of {1} and [?]", dealerCards[0], dealerSuit[0]);

                Console.WriteLine("You have  {0} vs House have {1} \n", playerTotal, dealerFirstTotal);

                Ask();
                hitOrStay = Console.ReadLine().ToLower();
            } while (!hitOrStay.Equals("hit") && !hitOrStay.Equals("stand") && !hitOrStay.Equals("end"));



            Game();
        }
        private void Ask()
        {

            Console.WriteLine("Choose: hit - To Take another card");
            Console.WriteLine("Choose: stand - To  stand");
            Console.WriteLine("Choose: Esc - To exit from game");
            Console.Write("You choose: ");

        }
        private void Game()
        {
            if (hitOrStay.Equals("hit"))
            {
                Hit();
            }
            else if (hitOrStay.Equals("stand"))
            {

                Stand();

            }

            Console.ReadLine();
        }

        private void PlayAgain()
        {
            string playAgain = "";
            do
            {
                playAgain = Console.ReadLine().ToLower();
            } while (!playAgain.Equals("y") && !playAgain.Equals("n"));
            if (playAgain.Equals("y"))
            {
                Console.WriteLine("\nPress enter to restart the game!");
                Console.ReadLine();
                Console.Clear();
                dealerTotal = 0;
                count = 1;
                playerTotal = 0;
                dealerTotal = 0;

                Play();
            }
            else if (playAgain.Equals("n"))
            {
                Console.WriteLine("\nPress enter to close Blackjack.");
                Console.ReadLine();
                Environment.Exit(0);
            }

        }

        private int FirstTotal()
        {
            if (dealerCards[0] == "Ten" || dealerCards[0] == "Jack" || dealerCards[0] == "Queen" || dealerCards[0] == "King")
            {
                int number = 10;
                return number;
            }
            else if (dealerCards[0] == "Two")
            {
                int number = 2;
                return number;
            }
            else if (dealerCards[0] == "Three")
            {
                int number = 3;
                return number;
            }
            else if (dealerCards[0] == "Four")
            {
                int number = 4;
                return number;
            }
            else if (dealerCards[0] == "Five")
            {
                int number = 5;
                return number;
            }
            else if (dealerCards[0] == "Six")
            {
                int number = 6;
                return number;
            }
            else if (dealerCards[0] == "Seven")
            {
                int number = 7;
                return number;
            }
            else if (dealerCards[0] == "Eight")
            {
                int number = 8;
                return number;
            }
            else if (dealerCards[0] == "Nine")
            {
                int number = 9;
                return number;
            }
            else
            {
                int number = 11;
                return number;
            }


        }

        public void End()
        {
            Console.WriteLine("Are you sure that you want to exit the game : Y or N");
            hitOrStay = Console.ReadLine().ToUpper();
            if (hitOrStay.Equals("Y"))
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                dealerTotal = 0;
                playerTotal = 0;
                Play();
            }
        }

        private string GetPlayerCard()
        {
            string Card = "";
            int cards = rng.Next(1, 14);
            switch (cards)
            {
                case 1:
                    Card = "Two"; playerTotal += 2;
                    break;
                case 2:
                    Card = "Three"; playerTotal += 3;
                    break;
                case 3:
                    Card = "Four"; playerTotal += 4;
                    break;
                case 4:
                    Card = "Five"; playerTotal += 5;
                    break;
                case 5:
                    Card = "Six"; playerTotal += 6;
                    break;
                case 6:
                    Card = "Seven"; playerTotal += 7;
                    break;
                case 7:
                    Card = "Eight"; playerTotal += 8;
                    break;
                case 8:
                    Card = "Nine"; playerTotal += 9;
                    break;
                case 9:
                    Card = "Ten"; playerTotal += 10;
                    break;
                case 10:
                    Card = "Jack"; playerTotal += 10;
                    break;
                case 11:
                    Card = "Queen"; playerTotal += 10;
                    break;
                case 12:
                    Card = "King"; playerTotal += 10;
                    break;
                case 13:
                    Card = "Ace"; playerTotal += 11;
                    break;
                default:
                    Card = "2"; playerTotal += 2;
                    break;
            }
            return Card;
        }

        private string NewGame()
        {


            Console.WriteLine("Welcome to Game of Blackjack");


            Console.Write("Please enter you name: ");
            string yuorname = Console.ReadLine();
            Console.Clear();
            return yuorname;

        }

        private string GetDealerSuit()
        {
            string Suit = "";
            int suit = rng.Next(1, 4);
            switch (suit)
            {
                case 1:

                    Suit = "Clubs";

                    break;
                case 2:
                    Suit = "Heart";
                    break;
                case 3:
                    Suit = "Spade";
                    break;
                default:
                    Suit = "Dimand";
                    break;

            }
            return Suit;
        }

        private string GetComputerDealer()
        {
            string Card = "";
            int cards = rng.Next(1, 14);
            switch (cards)
            {
                case 1:
                    Card = "Two"; dealerTotal += 2;
                    break;
                case 2:
                    Card = "Three"; dealerTotal += 3;
                    break;
                case 3:
                    Card = "Four"; dealerTotal += 4;
                    break;
                case 4:
                    Card = "Five"; dealerTotal += 5;
                    break;
                case 5:
                    Card = "Six"; dealerTotal += 6;
                    break;
                case 6:
                    Card = "Seven"; dealerTotal += 7;
                    break;
                case 7:
                    Card = "Eight"; dealerTotal += 8;
                    break;
                case 8:
                    Card = "Nine"; dealerTotal += 9;
                    break;
                case 9:
                    Card = "Ten"; dealerTotal += 10;
                    break;
                case 10:
                    Card = "Jack"; dealerTotal += 10;
                    break;
                case 11:
                    Card = "Queen"; dealerTotal += 10;
                    break;
                case 12:
                    Card = "King"; dealerTotal += 10;
                    break;
                case 13:
                    Card = "Ace"; dealerTotal += 11;
                    break;
                default:
                    Card = "2"; dealerTotal += 2;
                    break;
            }
            return Card;
        }



        private void Hit()
        {
            count += 1;
            playerCards[count] = GetPlayerCard();
            playerSuit[count] = GetDealerSuit();
            Console.WriteLine("\nYou were dealed a(n):  {0} of " + playerCards[count] + ".\nYour new total is " + playerTotal + ".", playerSuit[count]);
            if (playerTotal.Equals(21) && (playerCards[0] == "Ace" || playerCards[1] == "Ace"))
            {
                Console.WriteLine("\nYou got Blackjack! The dealer's total was " + dealerTotal + ".\nWould you like to play again?");
                PlayAgain();
            }
            else if (playerTotal.Equals(21) && (dealerTotal < 21 || dealerTotal > 21))
            {
                Console.WriteLine("\nYou win.  The dealer's total was " + dealerTotal + ".\nWould you like to play again?");
                PlayAgain();
            }
            else if (playerTotal > 21)
            {
                Console.WriteLine("\nYou busted, therefore you lost. Sorry. The dealer's total was " + dealerTotal + ".\nWould you like to play again? y/n");
                PlayAgain();
            }
            else if (playerTotal < 21)
            {
                do
                {
                    Console.WriteLine("\nWhat do yuo want to do?");
                    Ask();
                    hitOrStay = Console.ReadLine().ToLower();
                } while (!hitOrStay.Equals("hit") && !hitOrStay.Equals("stand"));
                Game();
            }
            else
            {
                Console.WriteLine("Hit on võrdne 21");
            }
        }

        private void Stand()
        {

            while (dealerTotal < 16)
            {
                count += 1;
                dealerCards[count] = GetComputerDealer();
                dealerSuit[count] = GetDealerSuit();
                Console.WriteLine("\nDealer where dealt a(n):  {0} of " + dealerCards[count] + ".\nDealer new total is " + dealerTotal + ".", dealerSuit[count]);
                Thread.Sleep(1000);
            }

            if (playerCards[0] == "Ace" && playerCards[1] == "Jack" || playerCards[0] == "Ace" && playerCards[1] == "Queen" || playerCards[0] == "Ace" && playerCards[1] == "King")
            {
                Console.WriteLine("Congrats ! You have Blackjack !!!" + dealerTotal + ".\nWould you like to play again? y/n ");
                if (playerTotal.Equals(21) && (playerCards[0] == "Ace" || playerCards[1] == "Ace"))
                {
                    Console.WriteLine("\nYou got Blackjack! The dealer's total was " + dealerTotal + ".\nWould you like to play again?");
                    PlayAgain();
                }
            }
            else if (playerTotal > dealerTotal && playerTotal <= 21)
            {
                Console.WriteLine("\nCongrats! You won the game! The dealer's Hole card was {1} of {0} and  total was " + dealerTotal + ".\nWould you like to play again? y/n", dealerCards[1], dealerSuit[1]);
                PlayAgain();
            }

            else if (playerTotal < dealerTotal && dealerTotal <= 21)
            {
                Console.WriteLine("\nSorry, you lost! The dealer's Hole card was {1} of {0} and  total is " + dealerTotal + ".\nWould you like to play again? y/n", dealerCards[1], dealerSuit[1]);
                PlayAgain();
            }
            else if (dealerTotal > 21)

            {
                Console.WriteLine("\nCongrats! You won the game! The dealer's Hole card was {1} of {0} and  total was " + dealerTotal + ".\nWould you like to play again? y/n", dealerCards[1], dealerSuit[1]);
                PlayAgain();
            }
            else if (playerTotal == dealerTotal)
            {
                Console.WriteLine("No winnings You have Tie. The dealer's Hole card was {1} of {0} and  total is " + dealerTotal + ".\nWould you like to play again? y/n", dealerCards[1], dealerSuit[1]);
                PlayAgain();
            }
            else
            {
                Console.WriteLine("else  {1} of {0} and  total was " + dealerTotal + ".\nWould you like to play again? y/n", dealerCards[1], dealerSuit[1]);
                PlayAgain();
            }
        }


    }
}
