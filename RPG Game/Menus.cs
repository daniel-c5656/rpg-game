using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game
{
    internal class Menus
    {
        public static void MainMenu()
        {
            Console.WriteLine("C# RPG"); // Title to be changed later
            Console.WriteLine("by Daniel C");

            Console.WriteLine("[1] Play");
            Console.WriteLine("[2] Help/Credits");
            Console.WriteLine("[3] Exit");

            string option = MenuLogic.getOption(3);

            switch (option)
            {
                case "1":
                    // Play
                    Console.WriteLine("Playing");
                    break;
                case "2":
                    Help();
                    break;
                case "3":
                    // Exit
                    Console.WriteLine("Exiting");
                    break;
            }
        }
        public static void Help()
        {
            // Help and Credits here
            Console.WriteLine("Help placeholder");
        }
    }
    internal class MenuLogic
    {
        public static string getOption(int optionCount, string prompt = "Select option: ")
        {
            string[] validOptions = new string[optionCount];

            for (int i=0; i < optionCount; i++)
            {
                validOptions[i] = (i + 1).ToString();
            }

            Console.Write(prompt);
            string input = Console.ReadLine().Trim().ToLower();
            
            while (!validOptions.Contains(input))
            {
                Console.WriteLine("Invalid input, please try again.");
                Console.Write(prompt);
                input = Console.ReadLine().Trim().ToLower();
            }
            return input;
        }
    }
}
