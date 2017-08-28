using System;

namespace Fibonacci
{
    /// <summary>
    ///  İlk 20 fibonacci sayısını hesaplayarak diziye yerleştiren (dizinin boyutu 20’lik olacaktır) program.  
    /// </summary>
    
    class Program
    {
        // Non-recursive fibonacci function.
        static int fibonacci(int num)
        {
            if (num == 0)
                return 0;

            int a = 0;
            int b = 1;

            // result 1 den basliyor cunku eger 1. fibonacci sayisi istenirse donguye hic girmeden cikacak ve 1. fibonacci sayimiz da 1 oldugu icin
            // baslangicta bu ihtimale karsi sonucumuzu 1'e setliyoruz.
            int result = 1;

            for (int i = 1; i < num; i++)
            {
                result = a + b;
                a = b;
                b = result;              
            }

            return result;
        }

        static void Main(string[] args)
        {
            int[] numbers = new int[20];

            for (int i = 1; i <= 20; i++)
            {
                numbers[i - 1] = fibonacci(i);
            }

            for (int i = 0; i < 20; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            // Press any key continue... yazisi altta ciksin diye ekliyorum.
            Console.WriteLine();
        }
    }     
}   
