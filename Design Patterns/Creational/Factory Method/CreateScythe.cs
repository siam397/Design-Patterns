using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Factory_Method
{
    internal class CreateScythe : ICreateWeapon
    {
        public Weapon createWeapon()
        {
            return new Scythe(40, 3, "Slash");
        }
    }
}
