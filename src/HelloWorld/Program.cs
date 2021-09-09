using System;

namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            IsLeapYear(2000);
        }

        public static bool IsLeapYear(int year)
        {
            var check = year % 4;
            Console.WriteLine(check);
            if (check == 0)
            {
                return true;
            }
            return false;
        }
    }
}
