using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    public class Money
    {
        // Поля для зберігання цілої частини та копійок
        private int dollars;
        private int cents;

        // Властивості для доступу до доларів і центів
        public int Dollars { get { return dollars; } }
        public int Cents { get { return cents; } }

        // Конструктор для ініціалізації значень
        public Money(int dollars, int cents)
        {
            this.dollars = dollars;
            this.cents = cents;
        }

        // Метод для виведення суми на екран
        public void PrintAmount()
        {
            Console.WriteLine($"Повна сума: {dollars}.{cents:D2}");
        }

        // Метод для задання значень частин
        public void SetAmount(int dollars, int cents)
        {
            this.dollars = dollars;
            this.cents = cents;
        }
    }
}
