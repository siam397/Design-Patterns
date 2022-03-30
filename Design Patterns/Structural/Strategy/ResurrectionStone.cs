using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural.Strategy
{
    internal class ResurrectionStone : IConsumable
    {
        public void consume()
        {
            Console.WriteLine("Player revived!!!");
        }
    }
}
