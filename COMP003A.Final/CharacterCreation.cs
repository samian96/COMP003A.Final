using System;
using System.Collections.Generic;
using System.Text;

namespace COMP003A.Final
{
    internal class CharacterCreation
    {
        string Name;

        string Classes;

        string Species;

        int Health;

        int MP;

        int Level;

        public CharacterCreation(string name, string classes, string species, int health, int mp, int level)
        {
            Name = name;

            Classes = classes;

            Species = species;

            Health = health;

            MP = mp;

            Level = level;
        }
    }
}
