using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    public class Product
    {
        // Поля класу Product
        private string name;
        private Money price;

        // Властивості для доступу до назви продукту та ціни
        public string Name { get { return name; } }
        public Money Price { get { return price; } }

        // Конструктор
        public Product(string name, Money price)
        {
            this.name = name;
            this.price = price;
        }

        // Метод для зменшення ціни на задану суму
        public void ReducePrice(Money amount)
        {
            this.price.SetAmount(this.price.Dollars - amount.Dollars, this.price.Cents - amount.Cents);
        }
    }
}
