using System;

namespace SinglyLinkedList
{
    /// <summary>
    ///  Bir bağlı liste oluşturan ve verilen bir tam sayı dizisinden (integer array) bu bağlı listeye sayı ekleyen kod.
    ///  Kodumuza bağlı listeyi ekrana bastıran bir fonksiyon ekleyerek liste içeriğini de ekrana bastırır.
    /// </summary>
    
    public class Node
    {
        public Node next;       // Bir sonraki elemana erismemizi saglayacak degiskenimiz. 
        public int value;       // Dugumlerin integer tipinde degerlerini tutacak.
    }

    public class LinkedList
    {
        private Node head;      // Bagli listemizin header'i.
        private Node current;   // Bagli listemizin son elemanini gosterecek.
        public int count;       // Bagli listemizin boyutunu gosterecek.

        public LinkedList()
        {
            head = new Node();
            current = head;
        }

        // Verilen diziyi bagli listemize ekleyen fonksiyon.
        public void add_array(int[] arr)
        {
            // Eklenecek yeni elemanlar icin surekli bagli listemizde dugum acmamiz gerek iste o dugumler bu degiskende tutulacak.
            Node newNode;

            for (int i = 0; i < arr.Length; i++)
			{
                newNode = new Node();   // Her indexte yeni bir dugum olusturuluyor.
                newNode.value = arr[i]; // Acilan dugumun degeri dizimizin degerine setleniyor.
                current.next = newNode; // Current'imizin nextini ekledigimiz elemana gosteriyoruz yani bagliyoruz birbirlerine.
                current = newNode;      // Current yani son elemanimiz artik yeni eklenen eleman oluyor.
                count++;	            // Bagli listemizin boyutu 1 artiyor.
			}
        }

        // Bagli listemizin elemanlarini ekrana basan fonksiyon.
        public void print()
        {
            // Dizimizi bu yardimci degisken ile gezip sonuna kadar olan tum elemanlari ekrana bastiracagiz.
            Node curr = head;

            while (curr.next != null)
            {
                curr = curr.next;
                Console.Write(curr.value + " ");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Bagli listemiz
            LinkedList list = new LinkedList();

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
            Console.WriteLine();
            // Bagli listemizi ekrana bastiriyoruz.
            list.print();

            // Press any key continue... cumlesi alt satira gecsin diye ekliyorum.
            Console.WriteLine();            
        }
    }     
}   
