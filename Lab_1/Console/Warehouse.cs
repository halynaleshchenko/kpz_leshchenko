using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    public class Warehouse
    {
        // Поля класу
        private string name;
        private string unit;
        private Money unitPrice;
        private int quantity;
        private DateTime lastRestockDate;
        private List<Product> products;
        private string currency;
        private Money initialCapital;
        private int maxProducts;
        private DateTime creationDate;
        private Reporting reporting;

        // Властивості класу 
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }

        public Money UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public DateTime LastRestockDate
        {
            get { return lastRestockDate; }
            set { lastRestockDate = value; }
        }

        public string Currency
        {
            get { return currency; }
            set { currency = value; }
        }

        public Money InitialCapital
        {
            get { return initialCapital; }
            set { initialCapital = value; }
        }

        public int MaxProducts
        {
            get { return maxProducts; }
            set { maxProducts = value; }
        }

        public List<Product> Products
        {
            get { return products; }
            set { products = value; }
        }
        public DateTime CreationDate
        {
            get { return creationDate; }
            set { creationDate = value; }
        }

        // Конструктор
        public Warehouse(string name, string unit, Money unitPrice, int quantity, DateTime lastRestockDate)
        {
            this.name = name;
            this.unit = unit;
            this.unitPrice = unitPrice;
            this.quantity = quantity;
            this.lastRestockDate = lastRestockDate;
            this.creationDate = DateTime.Now;
            this.reporting = new Reporting();
            this.products = new List<Product>();

        }

        // Метод для додавання товару на склад
        public void AddProduct(Product product)
        {
            products.Add(product);
            reporting.RegisterIncome(product);
        }

        // Метод для видалення товару зі складу - метод не використаний в program.cs
        public void RemoveProduct(Product product)
        {
            products.Remove(product);
            reporting.RegisterOutcome(product);
        }

        // Метод для виведення звіту по інвентаризації
        public void InventoryReport()
        {
            Console.WriteLine($"Склад: {name}");
            Console.WriteLine($"Одиниця виміру: {unit}");
            Console.WriteLine($"Ціна за одиницю: {unitPrice.Dollars}.{unitPrice.Cents:D2}");
            Console.WriteLine($"Кількість: {quantity}");
            Console.WriteLine($"Дата останнього поповнення: {lastRestockDate}");
            Console.WriteLine($"Доступні продукти:");
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name} - {product.Price.Dollars}.{product.Price.Cents:D2}");
            }
        }
    }
}

