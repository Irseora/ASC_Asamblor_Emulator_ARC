using System;
using System.IO;

namespace ASC_Asamblor_Emulator_ARC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Asamblor ARC: Programul traduce un program din limbaj de asamblare in cod masina.");
            string path = ReadPath();
            Console.WriteLine("-------------------------------------------------------------------------------");

            try
            {
                
            }
            // Daca fisierul nu poate fi citit, afiseaza mesajul exceptiei
            catch (IOException e)
            {
                Console.WriteLine("Fisierul nu poate fi citit:");
                Console.WriteLine(e.Message);
            }

            // Programul se incheie dupa ce se apasa o tasta
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("Programul a fost tradus. Fisierul nou: <<fisier_tradus>>");
            Console.WriteLine("Apasati orice tasta pentru a incheia programul...");
            Console.ReadKey();
        }

        /// <summary> Citeste numele unui fisier </summary>
        /// <returns> Numele fisierului citit </returns>
        static string ReadPath()
        {
            Console.Write("Numele fisierului de cod in limbaj de asamblare: ");
            string path = Console.ReadLine();

            // Citeste pana primeste un fisier care exista
            while (!File.Exists(path))
            {
                Console.WriteLine("Fisierul introdus nu exista!");
                Console.Write("Numele fisierului de cod in limbaj de asamblare: ");

                path = Console.ReadLine();
            }

            return path;
        }
    }
}