using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console5
{
    public class TextDocument
    {
        private string _content;

        public TextDocument(string content)
        {
            _content = content;
        }

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
    }
}
