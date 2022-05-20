using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Prototype
{
    internal class BossCloneMaster : ICloneBoss
    {
        public void Attack()
        {
            Console.WriteLine("SLASH");
        }

        public ICloneBoss? Clone()
        {
            return (BossCloneMaster?)this.MemberwiseClone() ;
        }
    }
}
