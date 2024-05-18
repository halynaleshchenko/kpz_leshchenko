using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console5
{
    public abstract class LightNodeWithLifecycle : LightNode
    {
        protected virtual void OnCreated() { }
        protected virtual void OnInserted() { }
        protected virtual void OnRemoved() { }
        protected virtual void OnStylesApplied() { }
        protected virtual void OnClassListApplied() { }
        protected virtual void OnTextRendered() { }

        public LightNodeWithLifecycle()
        {
            OnCreated();
        }
    }
}
