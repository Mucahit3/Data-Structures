using System;
using System.Collections.Generic;

namespace ReverseArrayWithStack
{
    /// <summary>
    ///  Bir yığın(stack) yapısı kullanarak verilen bir dizinin tersini alan kod.
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            // Stack nesnemiz.
            Stack<int> stack = new Stack<int>();
            // Random sayi atamak icin gerekli degisken.
            Random r = new Random();

            // Array'imiz random sayilarla doldurulacak.
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(100);
                Console.Write(array[i] + " ");
                stack.Push(array[i]);
            }

            // Arada bosluk olsun diye ekliyorum.
            Console.WriteLine();

            foreach (int item in stack)
            {
                Console.Write(item + " ");
            }

            // Press any key continue... yazisi alt satirda kalsin diye ekliyorum.
            Console.WriteLine();
        }
    }
}   
