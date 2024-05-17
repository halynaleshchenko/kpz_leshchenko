using Console3;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console3
{
    class Program
    {
        static void Main()
        {          
            var buttonElement = new LightElementNode("button", "inline", "closing", new List<string> { "btn" }, new List<LightNode>());

            buttonElement.AddEventListener("click", () => Console.WriteLine("Button clicked!"));

            buttonElement.TriggerEvent("click");

            Console.WriteLine("\nButton OuterHTML:");
            Console.WriteLine(buttonElement.OuterHTML);
        }
    }
}
