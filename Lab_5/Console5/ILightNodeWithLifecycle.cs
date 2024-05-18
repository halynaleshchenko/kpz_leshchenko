using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console5
{
    public interface ILightNodeWithLifecycle
    {
        void OnCreated();
        void OnInserted();
        void OnRemoved();
        void OnStylesApplied();
        void OnClassListApplied();
        void OnTextRendered();
    }
}
