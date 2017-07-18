using System;
using System.Collections.Generic;

namespace MergeLinkedLists
{
    /// <summary>
    ///  İki bağlı listeyi parametre alarak bu bağlı listelerin birleştirilmiş halini döndüren bir fonksiyon.
    ///  Merge fonksiyonu.
    /// </summary>

    public class Node
    {
        public Node next;       // Bir sonraki elemana erismemizi saglayacak degiskenimiz. 
        public int value;       // Dugumlerin integer tipinde degerlerini tutacak.
    }

    public class LinkedList
    {
        public Node head;      // Bagli listemizin header'i.
        public int count;       // Bagli listemizin boyutunu gosterecek.

        public LinkedList()
        {
            head = new Node();
            count = 0;
        }

        // Verilen diziyi bagli listemize ekleyen fonksiyon.
        public void add_array(int[] arr)
        {
            // Eklenecek yeni elemanlar icin surekli bagli listemizde dugum acmamiz gerek iste o dugumler bu degiskende tutulacak.
            Node newNode;
            Node curr = head;

            for (int i = 0; i < arr.Length; i++)
            {
                newNode = new Node();   // Her indexte yeni bir dugum olusturuluyor.
                newNode.value = arr[i]; // Acilan dugumun degeri dizimizin degerine setleniyor.
                if (count == 0)
                {
                    head = newNode;
                    curr = head;
                }               
                else
                {
                    curr.next = newNode; // Current'imizin nextini ekledigimiz elemana gosteriyoruz yani bagliyoruz birbirlerine.
                    curr = newNode;      // Current yani son elemanimiz artik yeni eklenen eleman oluyor.           
                }
                count++;	             // Bagli listemizin boyutu 1 artiyor.
            }
        }

        // Bagli listemizin elemanlarini ekrana basan fonksiyon.
        public void print()
        {
            // Dizimizi bu yardimci degisken ile gezip sonuna kadar olan tum elemanlari ekrana bastiracagiz.
            Node curr = head;

            while (curr != null)
            {
                Console.Write(curr.value + " ");
                curr = curr.next;
            }
        }
    } 

    class Program
    {
        public static LinkedList Merge(LinkedList first, LinkedList second)
        {
            LinkedList result = new LinkedList();
            List<int> array = new List<int>();

            Node curr = first.head;

            while(curr != null)
            {
                array.Add(curr.value);
                curr = curr.next;
            }

            curr = second.head;

            while(curr != null)
            {
                array.Add(curr.value);
                curr = curr.next;
            }

            int[] temp = array.ToArray();

            result.add_array(temp);

            return result;
        }

        static void Main(string[] args)
        {
            // Bagli listelerimiz
            LinkedList first = new LinkedList();
            LinkedList second = new LinkedList();
            // Yukaridaki bagli listelerimizden olusturulan yeni bagli listemiz bu degiskende tutulacak.
            LinkedList result = new LinkedList();

            // Random sayi uretmek icin bu degiskeni tanimliyoruz.
            Random r = new Random();
            // Sayilarimiz bu integer dizisinde duracak.
            int[] array = new int[10];

            // Sayilari random olarak atiyoruz. Next(1000) fonksiyonu 1000 e kadar olan sayilardan rastgele uretecek.
            for (int i = 0; i < array.Length; i++)
                array[i] = r.Next(1000);

            // Dizimizi bagli listemize veriyoruz.
            first.add_array(array);

            // Sayilari random olarak atiyoruz. Next(1000) fonksiyonu 1000 e kadar olan sayilardan rastgele uretecek.
            for (int i = 0; i < array.Length; i++)
                array[i] = r.Next(1000);

            // Dizimizi bagli listemize veriyoruz.
            second.add_array(array);

            first.print();
            Console.WriteLine();
            second.print();
            
            result = Merge(first, second);
            Console.WriteLine();
            // Bagli listemizi ekrana bastiriyoruz.
            result.print();

            // Press any key continue... cumlesi alt satira gecsin diye ekliyorum.
            Console.WriteLine();
        }
    }
}   
