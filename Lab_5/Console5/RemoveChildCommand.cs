using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console5
{
    public class RemoveChildCommand : ICommand
    {
        private LightElementNode parent;
        private LightNode child;

        public RemoveChildCommand(LightElementNode parent, LightNode child)
        {
            this.parent = parent;
            this.child = child;
        }

        public void Execute()
        {
            parent.ChildNodes.Remove(child);
        }

        public void Undo()
        {
            parent.ChildNodes.Add(child);
        }
    }
}
