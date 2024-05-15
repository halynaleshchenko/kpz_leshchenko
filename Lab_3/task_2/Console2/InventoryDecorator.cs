using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2
{
    abstract class InventoryDecorator : IInventory
    {
        protected Hero hero;
        public InventoryDecorator(Hero hero)
        {
            this.hero = hero;
        }

        public virtual void Equip()
        {
            Console.WriteLine($"Equipping inventory for {hero.Name}");
        }
    }
}
