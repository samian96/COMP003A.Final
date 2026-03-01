using System;
using System.Collections.Generic;
using System.Text;

namespace COMP003A.Final
{
    public class CharacterCreation
    {
        public string Name;

        public string Classes;

        public string Species;
 
        public int Health;

        public int MP;

        public int Level;
    
        public void DisplayCharacter()
        {
            Console.WriteLine();

            Console.WriteLine("Name: " + Name);

            Console.WriteLine("Class: " + Classes);

            Console.WriteLine("Species: " + Species);

            Console.WriteLine("Health: " + Health);

            Console.WriteLine("MP: " + MP);

            Console.WriteLine("Level: " + Level);

            Console.WriteLine();
        }
        
    }
    public class CharTemplate
      {
        public string Name;

        public int StartingHealth;

        public int StartingMP;

        public int StartingLevel;

        public CharTemplate(string name, int health, int mp, int level)
        {
            Name = name;
            StartingHealth = health;
            StartingMP = mp;
            StartingLevel = level;
        }
      }
    }
