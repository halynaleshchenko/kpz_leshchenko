using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console5
{
    public abstract class LightNode : ILightNodeWithLifecycle
    {
        public virtual string OuterHTML { get; }
        public virtual string InnerHTML { get; }

        public virtual void OnCreated() { }
        public virtual void OnInserted() { }
        public virtual void OnRemoved() { }
        public virtual void OnStylesApplied() { }
        public virtual void OnClassListApplied() { }
        public virtual void OnTextRendered() { }
    }
}
