using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console4
{
    //читає вміст текстового файлу і перетворює його на двовимірний масив
    public class SmartTextReader
    {
        public char[,] ReadTextFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            int maxLength = lines[0].Length;
            foreach (string line in lines)
            {
                if (line.Length > maxLength)
                    maxLength = line.Length;
            }

            char[,] textArray = new char[lines.Length, maxLength];

            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < lines[i].Length; j++)
                {
                    textArray[i, j] = lines[i][j];
                }
            }

            return textArray;
        }
    }

}
