using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Console5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Feature1();
            Feature2();
        }

        private static void Feature1()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Feature1:");
            Console.ResetColor();
            var root = new LightElementNode("div", "", "", new List<string>(), new List<LightNode>
            {
                new LightTextNode("Hello, world!"),
                new LightElementNode("span", "", "", new List<string>{"class1"}, new List<LightNode>
                {
                    new LightTextNode("Nested span")
                })
            });

            var iterator = new LightNodeIterator(root);
            foreach (var node in iterator)
            {
                Console.WriteLine(node.OuterHTML);
            }
        }
        private static void Feature2()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Feature2:");
            Console.ResetColor();

            var root = new LightElementNode("div", "", "", new List<string>(), new List<LightNode>
            {
                new LightTextNode("Hello, world!"),
                new LightElementNode("span", "", "", new List<string>{"class1"}, new List<LightNode>
                {
                    new LightTextNode("Nested span")
                })
            });

            var newChild = new LightTextNode("New Child");
            var addChildCommand = new AddChildCommand(root, newChild);
            addChildCommand.Execute();

            var removeChildCommand = new RemoveChildCommand(root, newChild);
            removeChildCommand.Execute();
            removeChildCommand.Undo();

            Console.WriteLine(root.OuterHTML);
        }
    }
}
