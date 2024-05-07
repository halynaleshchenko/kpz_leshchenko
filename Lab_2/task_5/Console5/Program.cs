using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створення героя
            HeroBuilder heroBuilder = new HeroBuilder();
            CharacterDirector heroDirector = new CharacterDirector(heroBuilder);
            Character hero = heroDirector.BuildCharacter();
            Console.WriteLine("Hero:");
            hero.DisplayInfo();

            Console.WriteLine();

            // Створення ворога
            HeroBuilder enemyBuilder = new HeroBuilder();
            CharacterDirector enemyDirector = new CharacterDirector(enemyBuilder);
            Character enemy = enemyDirector.BuildCharacter();
            enemy.Name = "Evil John";
            Console.WriteLine("Enemy:");
            enemy.DisplayInfo();
        }
    }
}
