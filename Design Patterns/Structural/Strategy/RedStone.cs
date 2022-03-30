using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural.Strategy
{
    internal class RedStone : IConsumable
    {
        public void consume()
        {
            Console.WriteLine("Attack increased by 30");
        }
    }
}
