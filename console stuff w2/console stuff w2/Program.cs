using System;

namespace console_stuff_w2
{
    class Program
    {
        static void Main(string[] args)

        {
            // task 1
            //int x;
            //int y;
            //Console.WriteLine("give me 2 numbers");
            //x = Convert.ToInt32(Console.ReadLine());
            //y = Convert.ToInt32(Console.ReadLine());

            //x += y;
            //Console.WriteLine("the sum is " + x);
            //Console.ReadLine();

            // task2
            
            
            SuperHeroGame();
        }

        static void SuperHeroGame()
        {
            string mystring;
            string superman = "superman";
            string batman = "batman";

            Console.WriteLine("whos your favurate superhero (no caps plz)");
            mystring = Console.ReadLine();

            if (mystring == superman)
            {
                Console.WriteLine("lame");
            }
            else if (mystring == batman)
            {
                Console.WriteLine("nice");

            }
            else
            {
                Console.WriteLine("lmao not real, try again");
                SuperHeroGame();
            }
        }
    }
}