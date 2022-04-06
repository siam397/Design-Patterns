using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Builder
{
    public interface ICharacterBuilder
    {
        void createBaseCharacter(string name);
        void chooseWeapon();
        void chooseUniqueAbility();
        void showInformation();
    }
}
