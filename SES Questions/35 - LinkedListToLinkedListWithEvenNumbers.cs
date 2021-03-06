using System;
using System.Collections.Generic;

namespace LinkedListToLinkedListWithEvenNumbers
{
    /// <summary>
    ///  Bir bağlı listedeki çift sayıları bularak yeni bir bağlı listeye koyan ve bu yeni bağlı listeyi döndüren bir fonksiyon.
    ///  filter fonksiyonu.
    /// </summary>

    public class Node
    {
        public Node next;       // Bir sonraki elemana erismemizi saglayacak degiskenimiz. 
        public int value;       // Dugumlerin integer tipinde degerlerini tutacak.
    }

    public class LinkedList
    {
        private Node head;      // Bagli listemizin header'i.
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

        public LinkedList filter()
        {
            LinkedList result = new LinkedList();
            List<int> array = new List<int>();

            Node curr = head;

            while (curr != null)
            {
                if (curr.value % 2 == 0)
                    array.Add(curr.value);
                curr = curr.next;
            }

            int[] temp = array.ToArray();

            result.add_array(temp);

            return result;
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
        static void Main(string[] args)
        {
            // Bagli listemiz
            LinkedList list = new LinkedList();
            // Yukaridaki bagli listemizden olusturulan yeni bagli listemiz bu degiskende tutulacak.
            LinkedList result = new LinkedList();

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

            // Dizimizi bagli listemize veriyoruz.
            list.add_array(array);
            
            result = list.filter();
            Console.WriteLine();
            // Bagli listemizi ekrana bastiriyoruz.
            result.print();

            // Press any key continue... cumlesi alt satira gecsin diye ekliyorum.
            Console.WriteLine();
        }
    }
}   
