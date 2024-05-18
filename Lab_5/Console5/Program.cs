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
            Feature3();
            Feature4();
            Feature5();
            Feature6();
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
        private static void Feature3()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Feature3:");
            Console.ResetColor();

            var root = new LightElementNodeWithState("div", "", "", new List<string>(), new List<LightNode>
            {
                new LightTextNode("Hello, world!"),
                new LightElementNodeWithState("span", "", "", new List<string>{"class1"}, new List<LightNode>
                {
                    new LightTextNode("Nested span")
                })
            });

            var spanElement = (LightElementNodeWithState)root.ChildNodes[1];
            spanElement.SetStyleState(new HighlightStyleState());

            Console.WriteLine(root.OuterHTML);
        }
        private static void Feature4()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Feature4:");
            Console.ResetColor();

            var root = new LightElementNode("div", "", "", new List<string>(), new List<LightNode>
            {
                new LightTextNode("Hello, world!"),
                new LightElementNode("span", "", "", new List<string>{"class1"}, new List<LightNode>
                {
                    new LightTextNode("Nested span")
                })
            });

            Console.WriteLine(root.OuterHTML);
        }
        private static void Feature5()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Feature5:");
            Console.ResetColor();

            var visitor = new MyLightNodeVisitor();

            var textNode = new LightTextNodeWithVisitor("Hello, world!");

            textNode.Accept(visitor);

            var elementNode = new LightElementNodeWithVisitor("div", "block", "single", new List<string> { "class1", "class2" }, new List<LightNode> { textNode });

            elementNode.Accept(visitor);
        }

        private static void Feature6()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Feature6:");
            Console.ResetColor();

            var observer = new ConsoleLoggingObserver();

            var root = new ObservableLightElementNode("div", "", "", new List<string>(), new List<LightNode>
            {
                new ObservableLightTextNode("Hello, world!"),
                new ObservableLightElementNode("span", "", "", new List<string>{"class1"}, new List<LightNode>
                {
                    new ObservableLightTextNode("Nested span")
                })
            });

            root.AddObserver(observer);
            foreach (var child in root.ChildNodes)
            {
                if (child is ObservableLightNode observableChild)
                {
                    observableChild.AddObserver(observer);
                }
            }

            var textNode = (ObservableLightTextNode)root.ChildNodes[0];
            textNode.Text = "Updated Hello, world!";

            Console.WriteLine(root.OuterHTML);
        }
    }
}
