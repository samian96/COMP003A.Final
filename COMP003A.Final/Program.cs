using System.Collections.Generic;

namespace COMP003A.Final
{
    internal class Program
    {
        private static List<CharacterCreation> character = new List<CharacterCreation>();

        private static List<CharTemplate> availableClasses = new List<CharTemplate>
        {
            new CharTemplate("Fighter", 120, 30, 1),

            new CharTemplate("Mage", 40, 70, 1),

            new CharTemplate("Stealth", 60, 40, 1),

        };

        static void Main(string[] args)
        {

            bool running = true;

            while (running)
            {
                MenuDisplay();
                string userInput = Console.ReadLine()?.Trim(); ;

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Create Character Selected.");
                        CreateChar();
                        break;
                    case "2":
                        Console.WriteLine("View all characters selected.");
                        
                        break;
                    case "3":
                        Console.WriteLine("View Character Stats Selected.");
                        break;
                    case "4":
                        Console.WriteLine("Remove Character Selected.");
                        break;
                    case "5":
                        Console.WriteLine("Exiting Program.");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input, please try again.");
                        break;
                }
            }
        }
        static void MenuDisplay()
        {
            Console.WriteLine("Character Creation Menu:");
            Console.WriteLine("1. Create Character: \n2. View All Characters: \n3: View Character Stats: \nRemove Character: \nExit Program:");
            Console.Write("Choose an option: ");
        }
        static void CreateChar()
        {
            Console.Clear();
            Console.WriteLine("Creating New Character");

            Console.Write("Please enter your characters name: ");
            string charName = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(charName))
            {
                Console.WriteLine("Invalid name, name requires one character, returning to menu.");
                return;
            }

            Console.WriteLine("Enter species: ");
            string species = Console.ReadLine()?.Trim();
            if (string.IsNullOrEmpty(species))
            {
                species = "Unkown";
            }


            string charChoice = Console.ReadLine()?.Trim();

            string charClasses; 

            switch (charChoice)
            {
                case "1":
                    charClasses = "Fighter";
                    break;
                case "2":
                    charClasses = "Mage";
                    break;
                case "3":
                    charClasses = "Stealth";
                    break;
                default:
                    Console.WriteLine("\n Invalid choice. Please try again.");
                    Console.ReadLine();
                    return;
            }
            // success path
            Console.WriteLine("\n Character created.");
            Console.WriteLine($"Name: {charName}\nClass: {charClasses}");

            Console.WriteLine("Press enter to return to menu...");
            Console.ReadLine();

        }
        static void Case2()
        {

        }
    }
}
