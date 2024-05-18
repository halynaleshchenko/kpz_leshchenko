using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console5
{
    public class MyLightNodeVisitor : ILightNodeVisitor
    {
        public void Visit(LightTextNode textNode)
        {
            Console.WriteLine($"Visiting text node with text: {textNode.Text}");
        }

        public void Visit(LightElementNode elementNode)
        {
            Console.WriteLine($"Visiting element node with tag name: {elementNode.TagName}");
        }
    }
}
