using System;

namespace MergeStrings
{
    /// <summary>
    ///  İki dizgi alarak bu dizgilerin birleşmiş halini döndüren bir fonksiyon.
    /// </summary>
    
    class Program
    {
        // Bir dizgi (string) ve bir sayı alarak, verilen sayıdaki harfi döndüren bir fonksiyon.
        static string merge(string first, string second)
        {
            return (first + " " + second);
        }

        static void Main(string[] args)
        {
            string first = "Muhammet";
            string second = "Mucahit";
            
            // Birlestirilmis dizgimiz bu degiskende tutulacak.
            string result = merge(first, second);

            Console.WriteLine(result);
        }
    }     
}   
