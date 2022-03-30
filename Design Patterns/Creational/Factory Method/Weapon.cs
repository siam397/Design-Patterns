using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Factory_Method
{
    internal abstract class Weapon
    {
        private int baseAttack;
        private string weaponArt;
        private int speed;
        
        public Weapon(int baseAttack, int speed, string weaponArt)
        {
            this.baseAttack = baseAttack;    
            this.weaponArt=weaponArt;
            this.speed = speed; 
        }


    }
}
