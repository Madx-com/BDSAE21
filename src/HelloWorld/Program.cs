using System;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a year to check if It is a Leap Year:");
            var input = Console.ReadLine();
            int inputyear;
            if(Int32.TryParse(input, out inputyear))
            {
                if(IsLeapYear(inputyear))
                {
                    Console.WriteLine("yay");
                }
                else
                {
                    Console.WriteLine("nay");
                }
            }
            // no loop yet
        }

        public static bool IsLeapYear(int year)
        {
            if (year%4 == 0 )
            {
                if (year%100 == 0 && year%400 != 0)
                {
                    return false;
                }

                return true;
            }
            return false;
        }
    }
}
