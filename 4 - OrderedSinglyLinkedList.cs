using System;

namespace OrderedSinglyLinkedList
{
    /// <summary>
    ///  Bağlı listenin ekleme fonksiyonuda sıralı şekilde eklemesini sağlayan kod. 
    ///  Karışık şekilde verilen bir diziyi, bağlı listeye ekleyen ve sonra bağlı listeyi ekrana bastıran kod.
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

        // Karisik sirada verilen diziyi bagli listemize sirali bir sekilde ekleyen fonksiyon.
        public void ordered_add_array(int[] arr)
        {
            // Eklenecek yeni elemanlar icin surekli bagli listemizde dugum acmamiz gerek iste o dugumler bu degiskende tutulacak.
            Node newNode;

            for (int i = 0; i < arr.Length; i++)
			{
                newNode = new Node();   // Her indexte yeni bir dugum olusturuluyor.
                newNode.value = arr[i]; // Acilan dugumun degeri dizimizin degerine setleniyor.

                // Eger dizimiz bossa yeni eklenen elemanimiz header'imiz olacak.
                if(count == 0)
                {
                    head = newNode;         
                }
                else
                {
                    // Yeni eklenen dugumumuz header'imizden kucukse yeni header'imiz eklenen dugum olacak.
                    if (newNode.value < head.value)
                    {
                        newNode.next = head;
                        head = newNode;
                    }
                    else
                    {
                        // curr degiskenimizle headerimizden baslayip eklenecek dugumumuzun hangi aralikla oldugu bulunmaya calisiyor.
                        Node curr = head;
                        while (curr.next != null)
                        {
                            if (newNode.value >= curr.next.value)
                                curr = curr.next;
                            else
                                break;
                        }

                        // Eklenecek dugumun konumu bulunduktan sonra ekleniyor.
                        newNode.next = curr.next;
                        curr.next = newNode;
                    }              
                }
                count++;	                // Bagli listemizin boyutu her eklenen dugumde 1 artiyor.
			}
        }

        // Bagli listemizin elemanlarini ekrana basan fonksiyon.
        public void print()
        {
            // Dizimizi bu yardimci degisken ile gezip sonuna kadar olan tum elemanlari ekrana bastiracagiz.
            Node curr = head;

            while (curr.next != null)
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
            list.ordered_add_array(array);
            Console.WriteLine();
            // Bagli listemizi ekrana bastiriyoruz.
            list.print();

            // Press any key continue... cumlesi alt satira gecsin diye ekliyorum.
            Console.WriteLine();           
        }
    }     
}   
