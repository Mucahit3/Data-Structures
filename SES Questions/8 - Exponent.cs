using System;

namespace Exponent
{
    /// <summary>
    ///  İki sayı alarak birinci sayının, ikinci sayı cinsinden üstünü bulan program. 
    /// </summary>
    
    class Program
    {
        static int pow(int bot, int top)
        {
            int result = bot;

            for (int i = 0; i < top - 1; i++)
            {
                result *= bot;
            }

            return result;
        }

        static void Main(string[] args)
        {
            int first, second;

            Console.Write("Please enter the first number : ");
            first = int.Parse(Console.ReadLine());

            Console.Write("Please enter the second number: ");
            second = int.Parse(Console.ReadLine());

            Console.WriteLine(pow(first, second));
        }
    }     
}   
