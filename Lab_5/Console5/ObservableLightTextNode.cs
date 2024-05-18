using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console5
{
    public class ObservableLightTextNode : ObservableLightNode
    {
        private string _text;

        public ObservableLightTextNode(string text)
        {
            _text = text;
            NotifyObservers();
        }

        public string Text
        {
            get => _text;
            set
            {
                _text = value;
                NotifyObservers();
            }
        }

        public override string OuterHTML => _text;

        public override string InnerHTML => _text;
    }
}
