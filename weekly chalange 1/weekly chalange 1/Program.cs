using System;
using System.Collections.Generic;

namespace weekly_chalange_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names =
            {
                "bob",
                "reece",
                "hannah",
                "callum",
                "adam"
            };

            Array.Sort<string>(names);
            foreach (string name in names)
            {
                Console.WriteLine("SORTED: " + new string(name));
            }
            Console.ReadKey();

            Array.Reverse<string>(names);
            foreach (string name in names)
            {
                Console.WriteLine("Reversed: " + new string(name));
            }
            Console.ReadKey();
        }
    }
}
