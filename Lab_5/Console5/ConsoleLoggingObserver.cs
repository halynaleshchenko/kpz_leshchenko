using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console5
{
    public class ConsoleLoggingObserver : ILightNodeObserver
    {
        public void OnNodeChanged(LightNode node)
        {
            Console.WriteLine($"Node changed: {node.OuterHTML}");
        }
    }
}
