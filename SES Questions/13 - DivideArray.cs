using System;

namespace DivideArray
{
    /// <summary>
    ///  Dizi bolen program.
    /// </summary>
    
    class Program
    {
        static void Main(string[] args)
        {
            // Random sayi uretmemiz icin gerekli nesne.
            Random r = new Random();
            // Sayilarimiz bu dizimiz icinde tutulacak ve degerler asagidaki for dongusuyle random olarak atanacak.
            int[] array = new int[20];

            // Dizilerimize hem deger atayip hem de ekrana bastiriyoruz.
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(100);
                Console.Write(array[i] + " ");
            }

            Console.Write("\nPlease enter the index number that you want to divide array from there: ");
            int number = int.Parse(Console.ReadLine());

            // Dizimiz bolununce ilk part'i ve ikinci part'i bu dizilerde saklanacak.
            int[] first = new int[number + 1];
            int[] second = new int[array.Length - (number + 1)];

            // Iki farkli for dongusunde de dizimize erisip kaldigimiz indeksten devam edebilmek icin tanimliyoruz.
            int j = 0;

            // Dizimizi ikiye bolup bolunen parcalari da direkt ekrana bastiriyoruz.
            for (int i = 0; i < first.Length; i++)
            {
                first[i] = array[j];
                j++;
                Console.Write(first[i] + " ");
            }

            // Iki cikti arasinda bosluk olsun diye yaziyorum.
            Console.WriteLine();

            for (int i = 0; i < second.Length; i++)
            {
                second[i] = array[j];
                j++;
                Console.Write(second[i] + " ");
            }

            // Press any key continue... yazisi altta ciksin diye ekliyorum.
            Console.WriteLine();
        }
    }     
}   
