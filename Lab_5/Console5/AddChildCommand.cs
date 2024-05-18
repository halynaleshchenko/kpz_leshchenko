using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console5
{
    public class AddChildCommand : ICommand
    {
        private LightElementNode parent;
        private LightNode child;

        public AddChildCommand(LightElementNode parent, LightNode child)
        {
            this.parent = parent;
            this.child = child;
        }

        public void Execute()
        {
            parent.ChildNodes.Add(child);
        }

        public void Undo()
        {
            parent.ChildNodes.Remove(child);
        }
    }
}
