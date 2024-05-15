using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2
{
    class ArmorDecorator : InventoryDecorator
    {
        public ArmorDecorator(Hero hero) : base(hero) { }

        public override void Equip()
        {
            base.Equip();
            Console.WriteLine("Equipping armor");
        }
    }
}
