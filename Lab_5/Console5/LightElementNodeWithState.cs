using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console5
{
    public class LightElementNodeWithState : LightElementNode
    {
        private IStyleState styleState;

        public LightElementNodeWithState(string tagName, string displayType, string closingType, List<string> cssClasses, List<LightNode> children)
            : base(tagName, displayType, closingType, cssClasses, children)
        {
            styleState = new DefaultStyleState();
        }

        public void SetStyleState(IStyleState newState)
        {
            styleState = newState;
            styleState.ApplyStyle(this);
        }
    }
}
