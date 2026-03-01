using System.Collections.Generic;

namespace COMP003A.Final
{
    internal class Program
    {
        private static List<CharacterCreation> character = new List<CharacterCreation>();

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
                        Console.Clear();
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
                if (running)
                {
                    Console.WriteLine("\n Press enter to continue.");
                    Console.ReadLine();
                    Console.Clear();
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
            string species = Console.ReadLine();
            if (species == "" || species == null)
            {
                species = "Unknown";
            }

            Console.WriteLine("");
            Console.WriteLine("Choose your class");
            Console.WriteLine("1. Fighter/ HP:120/ MP:30");
            Console.WriteLine("2. Mage/ HP:40/ MP:70");
            Console.WriteLine("3. Stealth/ HP:60/ MP:40");

            Console.Write("Enter choice 1-3: ");
            string charChoice = Console.ReadLine();

            int choice = 0;
            if(int.TryParse(charChoice, out choice) == false)
            {
                Console.WriteLine("Incorrect choice, try again.");
                return;
            }
            if (choice < 1 || choice > 3 )
            {
                Console.WriteLine("Invalid choice, please enter 1-3.");
                    return;
            }
            string className = "";
            int health = 0;
            int mp = 0;
            int level = 1;

            if (choice == 1)
            {
                className = "Fighter";
                health = 120;
                mp = 30;
            }
            else if (choice == 2)
            {
                className = "Mage";
                health = 40;
                mp = 70;
            }
            else if ( choice == 3)
            {
                className = "Stealth";
                health = 60;
                mp = 40;
            }
            CharacterCreation newChar = new CharacterCreation();
            newChar.Name = charName;
            newChar.ClassName = className;
            newChar.Species = species;
            newChar.Health = health;
            newChar.MP = mp;
            newChar.Level = 1;

            character.Add(newChar);

            Console.WriteLine("\n New Character has been created.");
        }
        static void Case2()
        {

        }
    }
}
