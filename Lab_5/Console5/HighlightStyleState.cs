using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console5
{
    public class HighlightStyleState : IStyleState
    {
        public void ApplyStyle(LightElementNode element)
        {
            element.ClassList.Clear();
            element.ClassList.Add("highlight");
        }
    }
}
