using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створення вірусів
            Virus originalVirus = new Virus(2.5, 3, "COVID-19", "Coronavirus");
            originalVirus.Children.Add(new Virus(1.8, 1, "Delta", "Variant"));
            originalVirus.Children.Add(new Virus(2.0, 2, "Omicron", "Variant"));

            // Клонування віруса
            Virus clonedVirus = (Virus)originalVirus.Clone();

            // Зміна деяких характеристик клонованого віруса
            clonedVirus.Name = "Alpha";
            clonedVirus.Age = 4;

            // Вивід інформації про оригінальний та клонований віруси
            Console.WriteLine("Original Virus:");
            Console.WriteLine(originalVirus);

            Console.WriteLine("\nCloned Virus:");
            Console.WriteLine(clonedVirus);

            Console.WriteLine("\nOriginal Virus Children:");
            foreach (var child in originalVirus.Children)
            {
                Console.WriteLine(child);
            }

            Console.WriteLine("\nCloned Virus Children:");
            foreach (var child in clonedVirus.Children)
            {
                Console.WriteLine(child);
            }

            Console.ReadKey();
        }
    }
}
