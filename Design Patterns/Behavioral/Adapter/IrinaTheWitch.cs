using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.Adapter
{
    internal class IrinaTheWitch : NPC
    {
        public IrinaTheWitch(string name, int health) : base(name, health)
        {
        }

        public void sellMagic(string magicName)
        {
            Console.WriteLine($"you now have the {magicName}");
        }
    }
}
