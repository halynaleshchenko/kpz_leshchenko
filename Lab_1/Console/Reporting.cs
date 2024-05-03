using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    public class Reporting
    {
        // Метод для реєстрації надходження товару
        public void RegisterIncome(Product product)
        {
            System.Console.WriteLine($"Продукт {product.Name} додано до звіту про доходи.");
        }

        // Метод для реєстрації відвантаження товару
        public void RegisterOutcome(Product product)
        {
            System.Console.WriteLine($"{product.Name} додано до звіту як видалений продукт.");
        }

        // Метод для складання звіту по інвентаризації
        public void GenerateInventoryReport(Warehouse warehouse)
        {
            warehouse.InventoryReport();
        }
    }
}
