using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    class FileLoggerAdapter : Logger
    {
        private FileWriter fileWriter;

        public FileLoggerAdapter(FileWriter fileWriter)
        {
            this.fileWriter = fileWriter;
        }
      
    }
}
