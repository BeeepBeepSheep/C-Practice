using System;

namespace coding_chalange_triangle__06_10_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Triangle();
            CodingChalange();

            Console.ReadLine();
        }
        static void Triangle()
        {
            int lineOne;
            int lineTwo;
            int lineThree;
            Console.WriteLine("give me the first side length of the triangle");
            lineOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("give me the second side length of the triangle");
            lineTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("give me the final side length of the triangle");
            lineThree = Convert.ToInt32(Console.ReadLine());

            string result = checkTriangle(lineOne,  lineTwo,  lineThree);

            Console.WriteLine(result);

            string checkTriangle(int lineOne, int lineTwo, int lineThree)
            {
                if (lineOne == lineTwo && lineOne == lineThree)
                {
                    result = "youre triangle is a equilateral";
                }
                else if (lineOne == lineTwo && lineOne != lineThree)
                {
                    result = "youre triangle is a isosceles";
                }
                else if (lineOne != lineTwo && lineOne == lineThree)
                {
                    result = "youre triangle is a isosceles";
                }
                else if (lineTwo == lineThree && lineOne != lineTwo)
                {
                    result = "youre triangle is a isosceles";
                }
                else
                {
                    result = "youre triangle is a scalene";
                }

                return result;
            }
        }
        static void CodingChalange()
        {
            int xHeight;
            string catagory = "";

            Console.WriteLine("how tall are you (cm)");
            xHeight = Convert.ToInt32(Console.ReadLine());
            if(xHeight < 150)
            {
                catagory = "dwarf";
            }
            else if (xHeight >=150 && xHeight < 165)
            {
                catagory = "avarage";
            }
            else if (xHeight >= 165)
            {
                catagory = "tall";
            }
            Console.WriteLine(catagory);
        }
    }
}
