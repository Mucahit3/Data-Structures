using System;

namespace BubbleSort
{
    /// <summary>
    ///  Karışık sırada verilen bir tam sayı dizisini, küçükten büyüğe doğru kabarcık (baloncuk) sıralaması ile (bubble sort) sıralayan kod.
    /// </summary>

    class Program
    {
        // Verilen diziyi Bubble Sort algoritmasi ile siralayip ekrana basan fonksiyon.
        static void bubble_sort(int[] arr)
        {
            // Distaki for dongusu diziyi bir kere elden gecirdikten sonra tekrar elden gecirmek icin var.
            // Yani mesela 2, 3, 1, 7, 6 olsun dizimiz ilk adimda su hale gelecek: 2, 1, 3, 6, 7 ama bu hali sirali degil o yuzden yine yapiyoruz.
            for (int j = 0; j < arr.Length; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        swap(ref arr[i], ref arr[i + 1]);
                    }
                }
            }
            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        // Verilen iki sayiyi birbirleriyle degistiren (swap) fonksiyon.
        static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

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

            Console.WriteLine("\nOrdered Array");
            Console.WriteLine("-------------");
            bubble_sort(array);
        }
    }     
}   
