using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural.Strategy
{
    internal class GreenStone : IConsumable
    {
        public void consume()
        {
            Console.WriteLine("Defense increased by 30");
        }
    }
}
