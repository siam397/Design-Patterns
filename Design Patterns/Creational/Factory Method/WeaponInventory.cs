using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Factory_Method
{
    public class WeaponInventory
    {
        ICreateWeapon[] weapons=new ICreateWeapon[2];
        public void setWeapons()
        {
            this.weapons[0]=new CreateSword();
            this.weapons[1] = new CreateScythe();
        }

        public void getWeapons()
        {
            foreach (var weapon in weapons)
            {
                Weapon newWeapon=weapon.createWeapon();
                Console.WriteLine($"new {newWeapon.GetType().Name} added to inventory.");
            }
        }
    }
}
