using System;

namespace MergeArrays
{
    /// <summary>
    ///  Dizi birleştiren program.
    /// </summary>
    
    class Program
    {
        static void Main(string[] args)
        {
            // Random sayi uretmemiz icin gerekli nesne.
            Random r = new Random();
            // Sayilarimiz bu dizilerimiz icinde tutulacak ve degerler asagidaki for dongusuyle random olarak atanacak.
            int[] first = new int[5];
            int[] second = new int[3];

            // Dizilerimize hem deger atayip hem de ekrana bastiriyoruz.
            for (int i = 0; i < first.Length; i++)
            {
                first[i] = r.Next(100);
                Console.Write(first[i] + " ");
            }

            // Iki cikti arasinda bosluk olsun diye yaziyorum.
            Console.WriteLine();
                
            for (int i = 0; i < second.Length; i++)
            {
                second[i] = r.Next(100);
                Console.Write(second[i] + " ");
            }

            // Iki dizimiz birlestikten sonra bu diziye atilacak.
            int[] result = new int[first.Length + second.Length];

            // 2 farkli dizide ayri iki for dongusunde dolasabilmek icin j degiskenini disarda tanimliyoruz.
            // Yani mesela ilk diziyi ekledik ikinci gelen dizi onun biraktigi yerden devam etmeli.
            int j = 0;

            // Iki dizimizi birlestirip simdi sonuc dizimize atiyoruz.
            for (int i = 0; i < first.Length; i++)
            {
                result[j] = first[i];
                j++;
            }

            for (int i = 0; i < second.Length; i++)
            {
                result[j] = second[i];
                j++;
            }

            // Iki cikti arasinda bosluk olsun diye yaziyorum.
            Console.WriteLine();

            // Birlestirilmis diziyi ekrana basiyoruz.
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }

            // Press any key continue... yazisi altta ciksin diye ekliyorum.
            Console.WriteLine();
        }
    }     
}   
