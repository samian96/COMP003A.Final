using System;
using System.Collections.Generic;
using System.Text;

namespace COMP003A.Final
{ // This Class is outside of the program to lesson the load where the main method is, and is called to when adding to the list for a new character, or leveling up the character.
    public class CharacterCreation
    {
        // main class customization
        public string Name;

        public string ClassName;

        public string Species;
 
        public int Health;

        public int MP;

        public int Level = 1;

        // deeper customization of character

        public string Age;

        public string Gender;

        public string HairColor;

        public string EyeColor;

        public bool IsAlive = true;

        public string Weapon;

        public string Armor;

        // sub division of abilities for combat health and ability 

        public int MaxHealth;

        public int CurrentHealth;

        public int MaxMP;

        public int CurrentMP;

        public int Strength;

        public int Dexterity;

        public int Defense;

        public int Intelligence;

        public int Wisdom;

        public int Speed;

        // Progress stats for battle if implemented

        public int Experience;

        public int Gold;


        // this section is to display everything in a list of the character created
        public void DisplayCharacter()
        {
            Console.WriteLine();

            Console.WriteLine("Name: " + Name);

            Console.WriteLine("Class: " + ClassName);

            Console.WriteLine("Species: " + Species);

            Console.WriteLine("Health: " + Health);

            Console.WriteLine("MP: " + MP);

            Console.WriteLine("Level: " + Level);

            Console.WriteLine("Age: " + Age);

            Console.WriteLine("Gender: " + Gender);

            Console.WriteLine("Hair Color: " + HairColor);

            Console.WriteLine("Eye Color: " + EyeColor);

            Console.WriteLine("Status: " + IsAlive);

            Console.WriteLine("Weapon: " + Weapon);

            Console.WriteLine("Armor: " + Armor);

            Console.WriteLine("MaxHealth: " + MaxHealth);

            Console.WriteLine("CurrentHealth: " + CurrentHealth);

            Console.WriteLine("MaxMP: " + MaxMP);

            Console.WriteLine("CurrentMP: " + CurrentMP);

            Console.WriteLine("Strength: " + Strength);

            Console.WriteLine("Dexterity: " + Dexterity);

            Console.WriteLine("Defense: " + Defense);

            Console.WriteLine("Intelligence: " + Intelligence);

            Console.WriteLine("Wisdom: " + Wisdom);

            Console.WriteLine("Speed: " + Speed);

            Console.WriteLine("Experience: " + Experience);

            Console.WriteLine("Gold: " + Gold);

            Console.WriteLine();
        }
        
    }
}
