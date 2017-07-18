using System;

namespace SearchStringInString
{
    /// <summary>
    ///  İlk dizginin, ikinci dizgide kaç kere tekrarlandığını bulan fonksiyon.
    /// </summary>
    
    class Program
    {
        static int search(string first, string second)
        {
            // Ilk dizgimiz ikinci dizgimiz icinde bulundukca degiskenimiz bir arttirilip sonucumuzu verecek.
            int count = 0;

            // Ikinci dizgimizi birinci dizgimiz uzunlugunca parca parca alip bu degisken icinde saklayacagiz.
            string temp;

            // Ilk dizgemiz boyutunca bolunen ve temp'e atanan kucuk dizgilerimiz aranan dizgimizle karsilastirilip sonuc bulunacak.
            for (int i = 0; i < second.Length - first.Length; i++)
            {
                // Substring fonksiyonu ilk parametre indexinden baslayip ikinci parametre kadar diziyi bolup temp'e atar.
                temp = second.Substring(i, first.Length);
                if (temp == first)
                    count++;
            }

            return count;
        }

        static void Main(string[] args)
        {
            string first = "mı";
            string second = "programımız çalışmıyor mu";
            
            
            // Birlestirilmis dizgimiz bu degiskende tutulacak.
            int result = search(first, second);

            Console.WriteLine(result);
        }
    }     
}   
