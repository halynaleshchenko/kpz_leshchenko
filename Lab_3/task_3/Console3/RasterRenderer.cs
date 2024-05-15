using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console3
{
    public class RasterRenderer : IRenderer
    {
        public void Render(string shapeType)
        {
            Console.WriteLine($"Drawing {shapeType} as pixels.");
        }
    }
}
