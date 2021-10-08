using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cards
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Deck = { "ace", "1", "2", "3", "4", "5", "6", "7", "8", "9", "jack", "queen", "king" }; // the deck
            string[] Type = { "Hearts", "diamonds", "clubs", "spades" };

            {
                Console.Clear();

                while (true)
                {
                    GenerateRandomCard();
                }
            }

            static void GenerateRandomCard()
            {

                Console.WriteLine("Your card is: " + Deck[rnd.Next(0, 14)] + " " + Type[rnd.Next(0, 3)] + "\n\npress an key to continue");

                Console.ReadKey();

                Console.Clear();
            }
        }
    }
}
