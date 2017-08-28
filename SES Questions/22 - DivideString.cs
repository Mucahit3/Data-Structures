using System;

namespace PrintString
{
    /// <summary>
    ///  Bir dizgi (string) ve bir sayı alarak, verilen sayıdaki harfi döndüren bir fonksiyon.
    /// </summary>
    
    class Program
    {
        // Bir dizgi (string) ve bir sayı alarak, verilen sayıdaki harfi döndüren bir fonksiyon.
        static string divide(string str, int num)
        {
            // Verilen sayiya kadar olan harfler bu gecici dizgimizde tutulacak.
            string temp = "";

            // Verilen sayiya kadar olan harfler gecici dizgimize ataniyor.
            for (int i = 0; i < num; i++)
            {
                temp += str[i];
            }

            return temp;
        }

        static void Main(string[] args)
        {
            string str = "Mucahit";
            int num = 4;

            string result = divide(str, num);
            Console.WriteLine(result);
        }
    }     
}   
