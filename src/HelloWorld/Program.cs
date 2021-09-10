using System;

namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static bool IsLeapYear(int year)
        {
            var check = year % 4;
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
