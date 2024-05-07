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
            DeviceFactory factory;

            // Вибираємо фабрику
            Console.WriteLine("Choose a factory (1 - IPhone, 2 - Xiaomi, 3 - Galaxy):");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    factory = new IPhoneFactory();
                    break;
                case 2:
                    factory = new XiaomiFactory();
                    break;
                case 3:
                    factory = new GalaxyFactory();
                    break;
                default:
                    throw new ArgumentException("Invalid choice");
            }

            // Створюємо девайси
            Device laptop = factory.CreateLaptop();
            Device smartphone = factory.CreateSmartphone();

            // Виводимо інформацію про девайси
            laptop.DisplayInfo();
            smartphone.DisplayInfo();
        }
    }

}