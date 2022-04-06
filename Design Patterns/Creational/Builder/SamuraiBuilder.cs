using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Builder
{
    internal class SamuraiBuilder:ICharacterBuilder
    {
        private Character? character;

        public void chooseUniqueAbility()
        {
            this.character?.setUniqueAbility("Slash of Death");
        }

        public void chooseWeapon()
        {
            this.character?.setWeapon("Katana");
        }

        public void createBaseCharacter(string name)
        {
            this.character = new Character(name, "Samurai");
        }

        public void showInformation()
        {
            this.character?.showCharacterInfo();
        }
    }
}
