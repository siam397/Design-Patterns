using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.Adapter
{
    internal class NPC
    {
        private string _name;
        private int _health;        
        public NPC(string name,int health)
        {
            _name = name;       
            _health = health;
        }
        public virtual void talk()
        {
            Console.WriteLine("Hello there.");
        }
    }
}
