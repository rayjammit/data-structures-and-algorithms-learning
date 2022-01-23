using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithmsConsole
{
    internal class MainMenu
    {

        Dictionary<string, string> menu;
        private readonly string EXIT = "EXIT";

        string[] validSelections = new string[] { "EXIT" };
        string[] selectionDetails = new string[] { "Type 'exit' to leave the program" };
        bool exiting;

        /// <summary>
        /// Constructor for MainMenu item
        /// </summary>
        public MainMenu()
        {
            menu = new Dictionary<string, string>();

            menu.Add("1", "Not yet implemented");
            menu.Add(EXIT, "Type 'exit' to leave the program");

            exiting = false;
        }

        public void InteractWithMainMenu()
        {
            while (!exiting)
            {

                printMenu();
                
                string userInput = TakeUserInput();
                exiting = checkForExit(userInput);

            }
        }

        private void printMenu()
        {
            Console.WriteLine("Main menu:\n");

            for (int i = 0; i < menu.Count; i++)
            {
                Console.WriteLine("\t" + menu.ElementAt(i).Key + ": " + menu.ElementAt(i).Value);
            }
        }

        private bool checkForExit(string userInput)
        {
            if (userInput.ToUpper().Equals(EXIT))
            {
                return true;
            }
            return false;
        }

        private string TakeUserInput()
        {
            bool validInput = false;
            string? userSelection;

            while (!validInput)
            {
                Console.Write("\nMake selection: ");
                userSelection = Console.ReadLine();
                if (userSelection != null && validSelections.Contains(userSelection.ToUpper()))
                {
                    validInput = true;
                    return userSelection.ToUpper();
                }
                else
                {
                    validInput = false;
                    Console.WriteLine("\nInvalid input, try again.");
                }
            }
            return "EXIT";
        }


    }
}
