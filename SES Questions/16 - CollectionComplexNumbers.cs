using System;

namespace CollectionComplexNumbers
{
    /// <summary>
    ///  Karmaşık sayıları toplayan program.
    /// </summary>
    
    class Program
    {
        static void Main(string[] args)
        {
            // Random deger atamak icin gerekli nesnemiz.
            Random r = new Random();
            // Karmasik sayilarimiz bu dizilerimiz icinde tutulacak ve degerler asagidaki for dongusuyle random olarak atanacak.
            int[] first = new int[2];
            int[] second = new int[2];

            // Iki karmasik sayimiz toplandiktan sonra degerleri bu dizimizde tutulacak.
            int[] result = new int[2];

            // Dizilerimize hem deger atayip hem de ekrana bastiriyoruz.
            for (int i = 0; i < 2; i++)
            {
                first[i] = r.Next(10);
                second[i] = r.Next(10);
                result[i] = first[i] + second[i];
            }

            Console.WriteLine(first[0] + " + " + first[1] + "i");
            Console.WriteLine(second[0] + " + " + second[1] + "i");

            Console.WriteLine("\nResult:");
            Console.WriteLine(result[0] + " + " + result[1] + "i");
        }
    }     
}   
