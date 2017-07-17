using System;

namespace Palindrome
{
    /// <summary>
    ///  Sayılar üzerinde palindrome testi yapan ve verilen sayının palindrome olup olmadığını söyleyen program.
    /// </summary>
    
    class Program
    {
        // Girilen sayinin palindrom olup olmadigini soyleyen fonksiyon.
        static bool palindrome(int num)
        {
            // Girilen sayimizin kac basamak oldugu bu degiskende tutulacak.
            int Size = size(num);
            // Girilen sayinin basamak sayisi boyutunda bir dizi olusuturuyoruz.
            // Bu dizi basamaklardaki sayilari indexlerinde tutacak.
            int[] numbers = new int[Size];

            // Aslinda burda sayiyi tersten diziye yerlestiriyoruz ama sayi eger palindromsa bunun bir onemi yok ;)
            for (int i = 0; i < Size; i++)
            {
                numbers[i] = num % 10;
                num /= 10;
            }

            // Dizimizde tersten ilerleyebilmek icin gerekli degisken.
            int j = Size - 1;
            // Eger dizide sondan ve bastan karsilastirilan karsilikli elemanlardan hepsi esit cikarsa count 0 olarak kalacak aksi takdirde 1 olacak.
            int count = 0;

            // Sayinin yarisina kadar karsilastirma yapmamiz yeterli aksi takdirde her sayiyi 2 kere karsilastirmis olacagiz.
            for (int i = 0; i < Size / 2; i++)
            {
                if (numbers[i] != numbers[j])
                {
                    count = 1;
                    break;  // Palindrom olmadigini anladigimiz icin artik donguden cikiyoruz.
                }                    
                j--;
            }

            if (count == 0)
                return true;
            return false;
        }

        // Girilen sayinin kac basamakli oldugunu donduren fonksiyon.
        static int size(int num)
        {
            int count = 0;

            while(num > 0)
            {
                num /= 10;
                count++;
            }

            return count;
        }

        static void Main(string[] args)
        {
            int number;

            Console.Write("Please enter the number: ");
            number = int.Parse(Console.ReadLine());

            if (palindrome(number))
                Console.WriteLine("The number that you entered is palindrom number");
            else
                Console.WriteLine("The number that you entered is not palindrom number");
        }
    }     
}   
