using System.Text;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // Для коректного виведення укр.

            // Створення об'єктів Money
            Money money1 = new Money(10, 50);
            Money money2 = new Money(20, 75);
            Money money3 = new Money(15, 30);

            // Виведення суми на екран
            money1.PrintAmount();
            money2.PrintAmount();
            money3.PrintAmount();

            // Створення об'єктів Product
            Product product1 = new Product("'Яблука'", money1);
            Product product2 = new Product("'Квіти'", money2);
            Product product3 = new Product("'Помідори'", money3);
            Console.WriteLine("\n");

            // Зменшення ціни на задану суму
            Money reductionAmount = new Money(5, 25);
            product1.ReducePrice(reductionAmount);
            product2.ReducePrice(reductionAmount);
            product3.ReducePrice(reductionAmount);

            // Виведення нової ціни продукту
            Console.WriteLine("Акція 5.25");
            Console.WriteLine($"Нова ціна {product1.Name}: {product1.Price.Dollars}.{product1.Price.Cents:D2}");
            Console.WriteLine($"Нова ціна {product2.Name}: {product2.Price.Dollars}.{product2.Price.Cents:D2}");
            Console.WriteLine($"Нова ціна {product3.Name}: {product3.Price.Dollars}.{product3.Price.Cents:D2}");
            Console.WriteLine("\n");

            // Створення складу і додавання товарів
            Warehouse warehouse = new Warehouse("Склад АТБ", "шт", new Money(100, 0), 50, DateTime.Now);
            warehouse.AddProduct(product1);
            warehouse.AddProduct(product2);
            warehouse.AddProduct(product3);

            // Призначення значень властивостей
            warehouse.Currency = "$";
            warehouse.InitialCapital = new Money(1000, 0);
            warehouse.MaxProducts = 1000;
            warehouse.CreationDate = DateTime.Now;

            // Виведення інформації про склад
            Console.WriteLine($"Назва складу: {warehouse.Name}");
            Console.WriteLine($"Валюта: {warehouse.Currency}");
            Console.WriteLine($"Початковий капітал: {warehouse.InitialCapital.Dollars}.{warehouse.InitialCapital.Cents:D2}");
            Console.WriteLine($"Максимальна кількість товару: {warehouse.MaxProducts}");
            Console.WriteLine($"Дата створення складу: {warehouse.CreationDate}");
            Console.WriteLine("\n");

            // Виведення інформації про товари на складі
            Console.WriteLine("\nТовари на складі:");
            foreach (var product in warehouse.Products)
            {
                Console.WriteLine($"Назва: {product.Name}, Ціна: {product.Price.Dollars}.{product.Price.Cents:D2}");
            }

            Console.WriteLine("\n");

            // Звіт по інвентаризації
            Reporting reporting = new Reporting();
            reporting.GenerateInventoryReport(warehouse);
            Console.WriteLine("\n");

            // Видалення товару зі складу
            warehouse.RemoveProduct(product1);
            // Звіт по інвентаризації після видалення
            Console.WriteLine("\nПісля видалення 1 товару:");
            warehouse.InventoryReport();
        }
    }
}