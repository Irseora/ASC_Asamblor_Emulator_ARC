using System;
using System.IO;

namespace ASC_Asamblor_Emulator_ARC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asamblor -------------------------------------------------------------------------------------------
            Console.Clear();
            Console.WriteLine("Asamblor ARC: Programul traduce un program din limbaj de asamblare in cod masina.");
            string path = ReadPath();
            Console.WriteLine("-------------------------------------------------------------------------------");

            try
            {
                
            }
            catch (IOException e)
            {
                Console.WriteLine("Fisierul nu poate fi citit:");
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("Programul a fost tradus. Fisierul nou: <<fisier_tradus>>");
            Console.WriteLine("0: Exit");
            Console.WriteLine("1: Ruleaza programul");
            Console.Write("Alegeti o optiune (0 / 1): ");
            int option = int.Parse(Console.ReadLine());

            if (option == 0) return;

            // Emulator -------------------------------------------------------------------------------------------
            // Run <<fisier_tradus>>
            // Show registers + memory
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