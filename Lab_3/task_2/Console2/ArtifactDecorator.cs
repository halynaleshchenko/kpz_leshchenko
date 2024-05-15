using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2
{
    class ArtifactDecorator : InventoryDecorator
    {
        public ArtifactDecorator(Hero hero) : base(hero) { }

        public override void Equip()
        {
            base.Equip();
            Console.WriteLine("Equipping artifact");
        }
    }
}
