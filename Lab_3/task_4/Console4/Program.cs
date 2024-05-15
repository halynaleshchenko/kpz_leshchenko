using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Console4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Приклад використання SmartTextChecker
            SmartTextChecker checker = new SmartTextChecker();
            char[,] textArray = checker.ReadTextFile("example.txt");

            // Приклад використання SmartTextReaderLocker
            SmartTextReaderLocker locker = new SmartTextReaderLocker(@"limited.*");
            textArray = locker.ReadTextFile("limited_file.txt");
        }
    }
}
