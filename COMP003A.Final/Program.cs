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
                        Console.WriteLine("View all characters selected.");
                        DisplayCharacter();
                        break;
                    case "3":
                        Console.WriteLine("Level Up Character.");
                        LevelUp();
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
            Console.WriteLine("1. Create Character: \n2. View All Characters: \n3: Level Up Character: \n4: Remove Character: \nExit Program:");
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
        static void DisplayCharacter()
        {
            Console.Clear();
            Console.WriteLine("All available Characters:");
            Console.WriteLine("");

            if (character.Count == 0)
            {
                Console.WriteLine("No characters have been created. \nPlease choose option 1 in Main Menu.");
            }
            else
            {
                foreach (CharacterCreation ch in character)
                {
                    ch.DisplayCharacter();
                    Console.WriteLine("");
                }
            }
        }
        static void LevelUp()
        {
            Console.Clear();
            Console.WriteLine("Level Up A Character. \nPlease Choose a Character:");
            Console.WriteLine("");

            if (character.Count == 0)
            {
                Console.WriteLine("No characters are available for leveling up. Please create a character in option 1 of main menu.");
                return;
            }
            Console.Write("Enter the name of the character you wish to level up: ");
            string findName = Console.ReadLine().Trim();

            bool found = false;

            for (int i = 0; i < character.Count; i = i + 1)
            {
                if (character[i].Name == findName)
                {
                    found = true;

                    character[i].Level = character[i].Level + 1;

                    character[i].Health = character[i].Health + 10;
                    character[i].MP = character[i].MP + 5;

                    Console.WriteLine("");
                    Console.WriteLine(character[i].Name + "Successfully Leveled Up!" + character[i].Level);
                    character[i].DisplayCharacter();

                    break;
                }
                if (found == false)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Character" + findName + "was not found, please try again.");
                    Console.WriteLine("Use option 2 to view all characters, make sure name is spelled correctly.");

                }
                Console.WriteLine("");
                Console.WriteLine("Press enter to return to menu.");
                Console.ReadLine();
            }
        }
        static void RemoveCharacter()
        {
            Console.Clear();
            Console.WriteLine("Delete a Character");
            Console.WriteLine("");

            if (character.Count == 0)
            {
                Console.WriteLine("Currently there are no existing characters");
                Console.WriteLine("Please create a new character in option 1 in the main menu.");
                Console.WriteLine("Press enter to continue..");
                Console.ReadLine();
                return;
            }
            Console.Write("Please enter the name of the character you would like to delete: ");
            string nameRemove = Console.ReadLine().Trim();

            bool found = false;
            int i;


        }
    }
}
