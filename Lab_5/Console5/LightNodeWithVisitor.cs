using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console5
{
    public abstract class LightNodeWithVisitor : LightNode
    {
        public abstract void Accept(ILightNodeVisitor visitor);
    }
}
