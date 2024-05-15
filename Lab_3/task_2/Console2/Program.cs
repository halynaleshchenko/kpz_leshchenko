using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створення героїв
            var warrior = new Warrior("Warrior");
            var mage = new Mage("Mage");
            var paladin = new Paladin("Paladin");

            // Створення та екіпірування інвентарю для героїв
            var warriorInventory = new List<IInventory>
        {
            new ArmorDecorator(warrior),
            new WeaponDecorator(warrior),
            new ArtifactDecorator(warrior)
        };

            var mageInventory = new List<IInventory>
        {
            new ArmorDecorator(mage),
            new WeaponDecorator(mage),
            new ArtifactDecorator(mage)
        };

            var paladinInventory = new List<IInventory>
        {
            new ArmorDecorator(paladin),
            new WeaponDecorator(paladin),
            new ArtifactDecorator(paladin)
        };

            EquipInventory(warriorInventory);
            EquipInventory(mageInventory);
            EquipInventory(paladinInventory);
        }

        static void EquipInventory(List<IInventory> inventory)
        {
            foreach (var item in inventory)
            {
                item.Equip();
            }
        }
    }
}
