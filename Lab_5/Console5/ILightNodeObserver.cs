using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console5
{
    public interface ILightNodeObserver
    {
        void OnNodeChanged(LightNode node);
    }
}
