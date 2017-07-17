using System;

namespace PrintArray
{
    /// <summary>
    ///  Dizideki elemanları ekrana basan program.
    /// </summary>
    
    class Program
    {
        static void print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            // Press any key continue... yazisi alt satirda kalsin diye yaziyorum.
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // Random deger atamak icin gerekli nesnemiz.
            Random r = new Random();
            // Sayilarimiz bu dizimiz icinde tutulacak ve degerler asagidaki for dongusuyle random olarak atanacak.
            int[] array = new int[10];

            // Dizilerimize hem deger atayip hem de ekrana bastiriyoruz.
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(100);
                Console.Write(array[i] + " ");
            }

            // Iki cikti arasinda bosluk olmasi icin yaziyorum.
            Console.WriteLine();

            print(array);
        }
    }     
}   
