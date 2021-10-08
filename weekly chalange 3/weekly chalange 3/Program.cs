using System;

namespace weekly_chalange_3
{
    class Program
    {
        static void Main(string[] args)
        {

            MySuperHeroTest();

            Console.ReadLine();
        }

        static void MySuperHeroTest()
        {
            string mySuperhero;

            Console.WriteLine("give me a superhero");
            mySuperhero = Console.ReadLine().ToUpper();

            switch (mySuperhero)
            {

                case "BATMAN":
                    RichSuperHero();
                    break;

                case "IRONMAN":
                    RichSuperHero();
                    break;

                case "SPIDERMAN":
                    Console.WriteLine("webs");
                    break;

                case "HULK":
                    Console.WriteLine("strong");
                    break;

                case "SUPERMAN":
                    Console.WriteLine("super");
                    break;
                default:
                    Console.WriteLine("nope play again");
                    MySuperHeroTest();
                    break;
            }
        }
        static void RichSuperHero()
        {
            Console.WriteLine("rich");
        }
    }
}
}
