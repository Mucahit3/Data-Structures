using System;
using System.Collections.Generic;

namespace PalindromeControlWithStack
{
    /// <summary>
    ///  Yığın yapısı kullanarak verilen bir dizinin palindrome olup olmadığını kontrol eden kod.
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            // Stack nesnemiz.
            Stack<int> stack = new Stack<int>();

            Console.Write("Please enter a number: ");
            string number = Console.ReadLine();

            int[] numbers = new int[number.Length];

            for (int i = 0; i < number.Length; i++)
            {
                numbers[i] = number[i];
            }

            // Numaralar stack'e ters ekleniyor. Yani dizimizin tam tersi seklinde ekleniyor.
            for (int i = 0; i < numbers.Length; i++)
            {
                stack.Push(numbers[i]);
            }


            int j = 0;
            int count = 0;
            
            // Stack'imiz dizimizle ters oldugu icin stack'i ve diziyi karsilastirirsak eger palindromlarsa count numaranin basamak sayisi olacak
            // ve sonucumuz true olacak eger degilse count eksik kalacak ve palindrom olmayacak.
            foreach (int item in stack)
            {
                if (numbers[j] == item)
                    count++;
                j++;
            }

            if (count == numbers.Length)
                Console.WriteLine("The number is palindrome.");
            else
                Console.WriteLine("The number is not palindrome");
        }
    }
}   
