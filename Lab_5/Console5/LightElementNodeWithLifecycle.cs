using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console5
{
    public class LightElementNodeWithLifecycle : LightElementNode
    {
        public LightElementNodeWithLifecycle(string tagName, string displayType, string closingType, List<string> cssClasses, List<LightNode> children)
            : base(tagName, displayType, closingType, cssClasses, children)
        {
            OnCreated();
        }

        public override void OnCreated()
        {
            Console.WriteLine($"Element {TagName} created");
        }
    }
}
