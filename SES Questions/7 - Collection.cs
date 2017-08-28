using System;

namespace Collection
{
    /// <summary>
    ///  İki sayı alarak bu sayıların toplamını döndüren prgram.
    /// </summary>
    
    class Program
    {
        static int sum(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            int first, second;

            Console.Write("Please enter the first number : ");
            first = int.Parse(Console.ReadLine());

            Console.Write("Please enter the second number: ");
            second = int.Parse(Console.ReadLine());

            Console.WriteLine(sum(first, second));
        }
    }     
}   
