using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console5
{
    public class LightElementNodeWithVisitor : LightElementNode, IAcceptableNode
    {
        public LightElementNodeWithVisitor(string tagName, string displayType, string closingType, List<string> cssClasses, List<LightNode> children)
            : base(tagName, displayType, closingType, cssClasses, children)
        {
        }

        public void Accept(ILightNodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
