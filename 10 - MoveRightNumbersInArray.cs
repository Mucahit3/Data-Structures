using System;

namespace MoveRightNumbersInArray
{
    /// <summary>
    ///  Dizideki sayıları verilen bir sayı kadar (kullanıcıdan okuyarak) sağa kaydıran program.
    ///  Dizi saga kayacak ve mesela en sondaki eleman basa gelip devam edecek dairesel olarak kayacak yani.
    /// </summary>
    
    class Program
    {
        // Verilen diziyi verilen numara kadar saga kaydiran ve ekrana basan fonksiyon.
        static void move(int[] arr, int num)
        {
            // Kaydirilan dizimizi gecici dizimize yazip ekrana basacagiz.
            int[] temp = new int[arr.Length];

            // Gecici dizimizin indeksini tutacak.
            int j = num;

            for (int i = 0; i < arr.Length; i++)
            {
                // j indexi asacagi icin dairesel olarak donmek icin boyuta esit oldugu zaman 0'a yani basa donderiyoruz.
                if (j == arr.Length)
                    j = 0;
                temp[j] = arr[i];
                j++;
            }

            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write(temp[i] + " ");
            }
        }

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
            Console.Write("Please enter the number that you want to move array to right with that number: ");
            number = int.Parse(Console.ReadLine());

            // Dizimizin kaydirilmadan onceki hali.
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            // Iki cikti arasinda bosluk birakmak icin giriyorum.
            Console.WriteLine();

            // Dizimizin kaydirildiktan sonraki hali.
            move(array, number);

            // Press any key continue... yazisi altta ciksin diye ekliyorum.
            Console.WriteLine();
        }
    }     
}   
