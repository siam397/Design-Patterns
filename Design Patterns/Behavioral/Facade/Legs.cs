using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.Facade
{
    public class Legs
    {
        public void Walk(string place)
        {
            Console.WriteLine("Walking to "+place);
        }
    }
}
