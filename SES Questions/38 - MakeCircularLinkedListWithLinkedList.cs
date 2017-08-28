using System;

namespace MakeCircularLinkedListWithLinkedList
{
    /// <summary>
    ///  Bir bağlı listeyi parametre olarak alan ve bu bağlı listeyi dairesel bağlı listeye (circular linked list) çeviren fonksiyon.
    ///  Circular fonksiyonu.
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

        // Bagli listemizin elemanlarini ekrana basan fonksiyon. // Dairesel listeyi ekrana dogru basmak icin duzenlendi.
        public void print()
        {
            // Dizimizi bu yardimci degisken ile gezip sonuna kadar olan tum elemanlari ekrana bastiracagiz.
            Node curr = head;

            if (curr == head)
            {
                Console.Write(curr.value + " ");
                curr = curr.next;
            }

            while (curr != head)
            {
                Console.Write(curr.value + " ");
                curr = curr.next;
            }
        }
    } 

    class Program
    {
        public static LinkedList Circular(LinkedList list)
        {
            LinkedList result = new LinkedList();

            result = list;

            Node curr = result.head;

            while (curr.next != null)
                curr = curr.next;

            curr.next = result.head;

            return result;
        }

        static void Main(string[] args)
        {
            // Bagli listelerimiz
            LinkedList list = new LinkedList();
            // Yukaridaki bagli listemizden olusturulan yeni dairesel bagli listemiz bu degiskende tutulacak.
            LinkedList result = new LinkedList();

            // Random sayi uretmek icin bu degiskeni tanimliyoruz.
            Random r = new Random();
            // Sayilarimiz bu integer dizisinde duracak.
            int[] array = new int[10];

            // Sayilari random olarak atiyoruz. Next(1000) fonksiyonu 1000 e kadar olan sayilardan rastgele uretecek.
            for (int i = 0; i < array.Length; i++)
                array[i] = r.Next(1000);

            // Dizimizi bagli listemize veriyoruz.
            list.add_array(array);

            // Dairesel olmayan bagli listede calismadigi icin kapattim.
            //list.print();
            
            result = Circular(list);
            Console.WriteLine();
            // Bagli listemizi ekrana bastiriyoruz.
            result.print();

            // Press any key continue... cumlesi alt satira gecsin diye ekliyorum.
            Console.WriteLine();
        }
    }
}   
