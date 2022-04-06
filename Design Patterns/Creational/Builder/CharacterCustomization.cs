using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Builder
{
    public class CharacterCustomization
    {
        private ICharacterBuilder? _characterBuilder;
        public void construct(ICharacterBuilder characterBuilder,string name)
        {
            this._characterBuilder = characterBuilder;
            this._characterBuilder.createBaseCharacter(name);
            this._characterBuilder.chooseWeapon();
            this._characterBuilder.chooseUniqueAbility();
        }
    }
}
