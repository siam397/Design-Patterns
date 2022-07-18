using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.Flyweight
{
    public interface Player
    {
        void AssignWeapon(string weapon);
        void Display();
    }
}
