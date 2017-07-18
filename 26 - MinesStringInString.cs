using System;

namespace MinesStringInString
{
    /// <summary>
    ///  Simdilik yanlis isliyor gelistirilecek.
    ///  İki dizgi alarak ilk dizgiyi, ikinci dizgiden çıkaran fonksiyon. 
    ///  (örneğin ilk dizgi “mı” ikinci dizgi “programımız çalışmıyor mu” ise sonuç olarak “prograz çalışyor mu” dönecek)
    /// </summary>
    
    class Program
    {
        static string mines(string first, string second)
        {
            // 1. dizgimiz 2. dizgimizden cikarilip bu degiskende tutulacak yani sonuc bu degiskende tutulacak.
            string result = "";
            // 2. dizgimiz 1. dizginin boyutu kadar kucuk parcalara ayrilip karsilastirmak icin bu gecici string'de tutulacak.
            string temp;

            // Dizimizin boyutu substring metonunda asilmasin diye 2. dizgimizin boyutu - 1. dizgimizin boyutu kadar gidiyoruz.
            for (int i = 0; i < second.Length - first.Length; i++)
            {
                temp = second.Substring(i, first.Length);
                if (temp != first)
                    result += second[i];
                else
                    i += (first.Length - 1);
            }

            temp = second.Substring(second.Length - first.Length, first.Length);

            // Yukarida substring methodu dizinin boyutunu asmasin diye eksik gittigimiz icin eksik yerleri burda tanimliyoruz.
            for (int i = second.Length - first.Length; i < second.Length; i++)
            {
                if(!temp.Contains(first))
                    result += second[i];
            }

            return result;
        }

        static void Main(string[] args)
        {
            string first = "or m";
            string second = "programımız çalışmıyor mu";
            
            
            // Eksiltilmis dizgimiz bu degiskende tutulacak.
            string result = mines(first, second);

            Console.WriteLine(result);
        }
    }     
}   
