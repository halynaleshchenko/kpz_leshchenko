using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console5
{
    class CharacterDirector
    {
        private readonly ICharacterBuilder _builder;

        public CharacterDirector(ICharacterBuilder builder)
        {
            _builder = builder;
        }

        public Character BuildCharacter()
        {
            return _builder.SetName("John")
                           .SetHeight("Tall")
                           .SetBuild("Muscular")
                           .SetHairColor("Brown")
                           .SetEyeColor("Blue")
                           .SetClothing("Armor")
                           .AddToInventory("Sword")
                           .AddToInventory("Shield")
                           .Build();
        }
    }
}
