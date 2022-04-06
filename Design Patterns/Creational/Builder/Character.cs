using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Builder
{
    internal class Character
    {
        private string? name;
        private string? type;
        private string? weapon;
        private string? uniqueAbility;

        public Character(string name, string type)
        {
            this.name = name;   
            this.type = type;
        }

        public void setWeapon(string weaponName)
        {
            weapon = weaponName;
        }

        public void setUniqueAbility(string abilityName)
        {
            uniqueAbility = abilityName;
        }

        public void showCharacterInfo()
        {
            Console.WriteLine($"The name of your character is: {name}\nClass: {type}\n Weapon: {weapon}\nUnique Ability: {uniqueAbility}");
        }
    }
}
