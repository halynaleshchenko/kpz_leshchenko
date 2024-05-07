using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console5
{
    class HeroBuilder : ICharacterBuilder
    {
        private Character _character = new Character();

        public ICharacterBuilder SetName(string name)
        {
            _character.Name = name;
            return this;
        }

        public ICharacterBuilder SetHeight(string height)
        {
            _character.Height = height;
            return this;
        }

        public ICharacterBuilder SetBuild(string build)
        {
            _character.Build = build;
            return this;
        }

        public ICharacterBuilder SetHairColor(string hairColor)
        {
            _character.HairColor = hairColor;
            return this;
        }

        public ICharacterBuilder SetEyeColor(string eyeColor)
        {
            _character.EyeColor = eyeColor;
            return this;
        }

        public ICharacterBuilder SetClothing(string clothing)
        {
            _character.Clothing = clothing;
            return this;
        }

        public ICharacterBuilder AddToInventory(string item)
        {
            if (_character.Inventory == null)
                _character.Inventory = new List<string>();
            _character.Inventory.Add(item);
            return this;
        }

        public Character Build()
        {
            return _character;
        }
    }
}
