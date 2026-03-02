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
                        RemoveCharacter();
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
            Console.WriteLine("1. Create Character: \n2. View All Characters: \n3: Level Up Character: \n4: Remove Character: \n5. Exit Program:");
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
            Console.WriteLine();
            Console.Write("Enter Characters age: ");
            string charAge = Console.ReadLine()?.Trim();

            if (charAge == "" || charAge == null)
            {
                charAge = "Unkown";
            }

            Console.WriteLine();
            Console.Write("Enter characters gender: ");
            string charGender = Console.ReadLine()?.Trim();

            if (charGender == "" || charGender == null)
            {
                charGender = "Unknown";
            }

            Console.WriteLine();
            Console.Write("Enter characters hair color: ");
            string charHair = Console.ReadLine()?.Trim();

            if (charHair == "" || charHair == null)
            {
                charHair = "Bald";
            }

            Console.WriteLine();
            Console.WriteLine("Enter characters eye color: ");
            string charEyes = Console.ReadLine()?.Trim();

            if (charEyes == "" || charEyes == null)
            {
                charEyes = "Hazel";
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
            int maxHealth = 0;
            int currentHealth = 0;
            int maxMP = 0;
            int currentMP = 0;
            int strength = 10;
            int dexterity = 10;
            int defense = 10;
            int intelligence = 10;
            int wisdom = 10;
            int speed = 10;
            int gold = 0;
            int experience = 0;
            string weapon = "none";
            string armor = "none";

            if (choice == 1)
            {
                className = "Fighter";
                health = 120;
                mp = 30;
                strength = 40;
                defense = 30;
                wisdom = 8;
                speed = 15;
                maxHealth = 120;
                currentHealth = 120;
                maxMP = 30;
                currentMP = 30;
                weapon = "Great Sword";
                armor = "Half Plated Suit of Armor";



            }
            else if (choice == 2)
            {
                className = "Mage";
                health = 40;
                mp = 70;
                strength = 5;
                defense = 8;
                wisdom = 25;
                intelligence = 20;
                maxHealth = 40;
                currentHealth = 40;
                maxMP = 70;
                currentMP = 70;
                weapon = "Large Oak Staff";
                armor = "Garmet Robe";


            }
            else if ( choice == 3)
            {
                className = "Stealth";
                health = 60;
                mp = 40;
                strength = 15;
                defense = 15;
                speed = 30;
                dexterity = 20;
                gold = 50;
                maxHealth = 60;
                currentHealth = 60;
                maxMP = 40;
                currentMP = 40;
                weapon = "Curved Dagger";
                armor = "Lightweight Cloak";

            }
            CharacterCreation newChar = new CharacterCreation();
            newChar.Name = charName;
            newChar.ClassName = className;
            newChar.Species = species;
            newChar.Health = health;
            newChar.MP = mp;
            newChar.Level = 1;
            newChar.MaxHealth = maxHealth;
            newChar.CurrentHealth = currentHealth;
            newChar.MaxMP = maxMP;
            newChar.CurrentMP = currentMP;
            newChar.Strength = strength;
            newChar.Dexterity = dexterity;
            newChar.Defense = defense;
            newChar.Intelligence = intelligence;
            newChar.Wisdom = wisdom;
            newChar.Speed = speed;
            newChar.Gold = gold;
            newChar.Experience = experience;
            newChar.Age = charAge;
            newChar.Gender = charGender;
            newChar.HairColor = charHair;
            newChar.EyeColor = charEyes;
            newChar.Weapon = weapon;
            newChar.Armor = armor;




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
                    character[i].MaxHealth = character[i].MaxHealth + 10;
                    character[i].MaxMP = character[i].MaxMP + 5;
                    character[i].Strength = character[i].Strength + 5;
                    character[i].Dexterity = character[i].Dexterity + 3;
                    character[i].Defense = character[i].Defense + 5;
                    character[i].Intelligence = character[i].Intelligence + 3;
                    character[i].Wisdom = character[i].Wisdom + 2;
                    character[i].Speed = character[i].Speed + 2;
                    character[i].Gold = character[i].Gold + 15;
                    character[i].Experience = character[i].Experience + 30;

                    Console.WriteLine("");
                    Console.WriteLine(character[i].Name + " Successfully Leveled Up! " + character[i].Level);
                    character[i].DisplayCharacter();

                    break;
                }
                if (found == false)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Character " + findName + " was not found, please try again.");
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

            for (i = 0; i < character.Count; i = i+ 1)
            {
                found = true;

                Console.WriteLine("");
                Console.WriteLine("Character Found:" + character[i].DisplayCharacter);
                Console.WriteLine("");

                character.RemoveAt(i);

                Console.WriteLine("Character: " + nameRemove + " Has been deleted.");
                break;
            }
            if (found == false)
            {
                Console.WriteLine("\nCharacter: " + nameRemove + " was not found.");
                Console.WriteLine("Use option 2 to view all charaacters and check spelling.");
            }

        }
    }
}
