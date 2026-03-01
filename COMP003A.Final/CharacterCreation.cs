using System;
using System.Collections.Generic;
using System.Text;

namespace COMP003A.Final
{
    public class CharacterCreation
    {
        public string Name;

        public string ClassName;

        public string Species;
 
        public int Health;

        public int MP;

        public int Level = 1;
    
        public void DisplayCharacter()
        {
            Console.WriteLine();

            Console.WriteLine("Name: " + Name);

            Console.WriteLine("Class: " + ClassName);

            Console.WriteLine("Species: " + Species);

            Console.WriteLine("Health: " + Health);

            Console.WriteLine("MP: " + MP);

            Console.WriteLine("Level: " + Level);

            Console.WriteLine();
        }
        
    }
}
