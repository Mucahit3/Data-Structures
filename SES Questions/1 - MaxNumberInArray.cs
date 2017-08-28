using System;

namespace MaxNumberInArray
{
    /// <summary>
    ///  Bir tam sayı dizisindeki (integer array) en büyük sayıyı bulan kod.
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            // Random sayi uretmek icin bu degiskeni tanimliyoruz.
            Random r = new Random();
            // Sayilarimiz bu integer dizisinde duracak.
            int[] array = new int[10];

            // Sayilari random olarak atiyoruz. Next(1000) fonksiyonu 1000 e kadar olan sayilardan rastgele uretecek.
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(1000);
                Console.Write(array[i] + " ");
            }

            // Dizimizin en buyuk elemani bu degiskende tutulacak.
            int max = 0;

            // Eger dizimizin sirayla gelen elemani maxdan buyukse max o elemana esitleniyor ki bir sonraki gelen elemanin buyuk mu kucuk mu
            // oldugunu karsilastirabilelim.
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }

            // En buyuk elemanimizi yazdiriyoruz.
            Console.WriteLine("\n" + max);
        }
    }     
}   
