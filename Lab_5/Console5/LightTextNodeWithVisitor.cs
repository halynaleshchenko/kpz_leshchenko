using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console5
{
    public class LightTextNodeWithVisitor : LightTextNode, IAcceptableNode
    {
        public LightTextNodeWithVisitor(string text) : base(text) { }

        public void Accept(ILightNodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
