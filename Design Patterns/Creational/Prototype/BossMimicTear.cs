using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Prototype
{
    public class BossMimicTear : ICloneBoss
    {
        public void Attack()
        {
            Console.WriteLine("Does same attack as you");
        }

        public ICloneBoss? Clone()
        {
            return (BossMimicTear?)this.MemberwiseClone();
        }
    }
}
