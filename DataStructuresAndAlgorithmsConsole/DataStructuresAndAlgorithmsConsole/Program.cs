using System;

namespace DataStructuresAndAlgorithmsConsole
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Starting program...\n\n");

            MainMenu mainMenu = new MainMenu();
            mainMenu.InteractWithMainMenu();
            
            Console.WriteLine("Exiting program...");

        }

    }
}