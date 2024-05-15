using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console4
{
    // Проксі для SmartTextReader з логуванням
    public class SmartTextChecker : SmartTextReader
    {
        public new char[,] ReadTextFile(string filePath)
        {
            Console.WriteLine($"Opening file: {filePath}");
            char[,] textArray = base.ReadTextFile(filePath);
            Console.WriteLine($"File {filePath} successfully read.");
            Console.WriteLine($"Total lines: {textArray.GetLength(0)}");
            Console.WriteLine($"Total characters: {textArray.Length}");
            Console.WriteLine($"Closing file: {filePath}");
            return textArray;
        }
    }
}
