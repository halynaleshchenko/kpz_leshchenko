using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створюємо об'єкт FileWriter
            FileWriter fileWriter = new FileWriter();

            // Створюємо адаптер, який дозволить логувати у файл
            FileLoggerAdapter fileLoggerAdapter = new FileLoggerAdapter(fileWriter);

            // Використовуємо методи логера для запису у файл
            fileLoggerAdapter.Log("Logging to file: Info message");
            fileLoggerAdapter.Error("Logging to file: Error message");
            fileLoggerAdapter.Warn("Logging to file: Warning message");

        }
    }
}
