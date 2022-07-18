using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.Facade
{
    internal class Mouth
    {
        public void Consume(string consumable)
        {
            Console.WriteLine("Consuming "+consumable);
        }
    }
}
