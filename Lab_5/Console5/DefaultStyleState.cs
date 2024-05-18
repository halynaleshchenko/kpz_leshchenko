using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console5
{
    public class DefaultStyleState : IStyleState
    {
        public void ApplyStyle(LightElementNode element)
        {
            element.ClassList.Clear();
        }
    }
}
