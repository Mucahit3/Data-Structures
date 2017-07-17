using System;

namespace MultipleArrayWithNumber
{
    /// <summary>
    ///  Dizideki bütün sayıları verilen bir sayı ile (kullanıcıdan okuyup) çarpan program.
    /// </summary>
    
    class Program
    {
        static void Main(string[] args)
        {
            // Random sayi uretmemiz icin gerekli nesne.
            Random r = new Random();
            // Sayilarimiz bu dizimiz icinde tutulacak ve degerler asagidaki for dongusuyle random olarak atanacak.
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(100);
            }

            int number;
            Console.Write("Please enter the number that you want to multiple array's indexes with that number: ");
            number = int.Parse(Console.ReadLine());

            // Dizimizin carpilmadan onceki hali.
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            // Iki cikti arasinda bosluk birakmak icin giriyorum.
            Console.WriteLine();

            // Dizimizin carpilmadan sonraki hali.
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= number;
                Console.Write(array[i] + " ");
            }

            // Press any key continue... yazisi altta ciksin diye ekliyorum.
            Console.WriteLine();
        }
    }     
}   
