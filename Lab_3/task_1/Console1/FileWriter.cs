using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    class FileWriter
    {
        public void Write(string message)
        {
            // Логіка для запису у файл
            Console.WriteLine("Writing to file: " + message);
        }

        public void WriteLine(string message)
        {
            // Логіка для запису у файл з новим рядком
            Console.WriteLine("Writing to file: " + message);
        }
    }
}
