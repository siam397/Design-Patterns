using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.Adapter
{
    internal class AndreTheBlacksmith : NPC
    {
        private IrinaTheWitch irina = new IrinaTheWitch("big hat irina",60);

        public AndreTheBlacksmith(string name, int health) : base(name, health)
        {
        }

        public void sellWeapon(string weaponName)
        {
            Console.WriteLine($"you now have {weaponName}!");
        }

        public void fixWeapon(string weaponName)
        {
            Console.WriteLine($"{weaponName} fixed!");
        }

        public void sellHealingMagic()
        {
            this.irina.sellMagic("healer");
        }
            
    }
}
