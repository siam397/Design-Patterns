using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Factory_Method
{
    internal class Sword : Weapon
    {
        public Sword(int baseAttack, int speed, string weaponArt) : base(baseAttack, speed, weaponArt)
        {
        }
    }
}
