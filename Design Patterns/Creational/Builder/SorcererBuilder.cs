using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Builder
{
    internal class SorcererBuilder : ICharacterBuilder
    {
        private Character? character;
        public void chooseUniqueAbility()
        {
            this.character?.setUniqueAbility("Beam of Light");
        }

        public void chooseWeapon()
        {
            this.character?.setWeapon("Wizard stuff");
        }

        public void createBaseCharacter(string name)
        {
            this.character = new Character(name, "Sorcerer");
        }

        public void showInformation()
        {
            this.character?.showCharacterInfo();
        }
    }
}
