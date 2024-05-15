using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Console4
{
    public class SmartTextReaderLocker : SmartTextReader
    {
        private Regex accessRegex;

        public SmartTextReaderLocker(string accessPattern)
        {
            accessRegex = new Regex(accessPattern);
        }

        public new char[,] ReadTextFile(string filePath)
        {
            if (accessRegex.IsMatch(filePath))
            {
                Console.WriteLine("Access denied!");
                return null;
            }
            else
            {
                return base.ReadTextFile(filePath);
            }
        }
    }
}
