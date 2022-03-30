using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Factory_Method
{
    internal class CreateSword : ICreateWeapon
    {
        public Weapon createWeapon()
        {
            return new Sword(50, 3, "thurst");
        }
    }
}
