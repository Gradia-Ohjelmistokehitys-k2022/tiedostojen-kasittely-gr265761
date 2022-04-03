using System;
using System.IO;
namespace Program
{
    internal class Program
    {
        static bool OnOlemassa(string filename)
        {
            return File.Exists(filename);
        }
        static void Main(string[] args)
        {
            Console.Write("Anna tiedoston nimi: ");
            string x = Console.ReadLine();
            string path = @"C:\Users\gr265761\Visual Studio\tiedostojen-kasittely-gr265761\";

            if (OnOlemassa(path + x))
            {
                Console.WriteLine("Tiedosto " + x + " on olemassa");


                String[] rivit = { "Hello world!", "Uusi rivi tässä", "Huuhaa!" };
                File.WriteAllLines(@"C:\Users\gr265761\Visual Studio\tiedostojen-kasittely-gr265761\teksti1.txt", rivit);


            }
            else
            {
                Console.WriteLine("Tiedostoa " + x + " ei ole olemassa");
            }
        }
    }
}
