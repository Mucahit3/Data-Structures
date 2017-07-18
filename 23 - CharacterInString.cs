using System;

namespace CharacterInString
{
    /// <summary>
    ///  Bir dizgi ve bir karakteri parametre alarak, verilen karakterin, verilen dizgide kaç kere tekrarlandığını döndüren fonksiyon.
    /// </summary>
    
    class Program
    {
        // Bir dizgi (string) ve bir sayı alarak, verilen sayıdaki harfi döndüren bir fonksiyon.
        static int count(string str, char ch)
        {
            // Karakter dizgimizde bulundukca bu degiskenimiz bir arttirilacak ve sonucumuz olacak.
            int cnt = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                    cnt++;
            }

            return cnt;
        }

        static void Main(string[] args)
        {
            string str = "MuhammetMucahitAktepe";
            char ch = 'a';

            Console.WriteLine(count(str, ch));
        }
    }     
}
