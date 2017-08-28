using System;

namespace PrintEmailInformations
{
    /// <summary>
    ///  Klavyeden e-posta adresi okuyarak, posta adresindeki kullanıcı ve hostu ekrana yazan program.
    /// </summary>
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the email: ");
            string email = Console.ReadLine();

            string username = "";
            string host = "";

            int i;

            for (i = 0; email[i] != '@'; i++)
                username += email[i];

            // @ isaretinden kurtulmak icin i bir artiyor.
            i++;

            for (; i < email.Length; i++)
                host += email[i];

            Console.WriteLine("Username: " + username);
            Console.WriteLine("Host    : " + host);
        }
    }     
}   
