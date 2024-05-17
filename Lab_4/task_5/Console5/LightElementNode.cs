using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console5
{
    public class LightElementNode : LightNode
    {
        private string tagName;
        private List<string> cssClasses;
        private List<LightNode> children;


        public List<string> Attributes { get; set; }

        public LightElementNode(string tagName, string displayType, string closingType, List<string> cssClasses, List<LightNode> children)
        {
            this.tagName = tagName;
            this.cssClasses = cssClasses;
            this.children = children;
        }


        public string TagName => tagName;
        public List<string> ClassList => cssClasses;
        public List<LightNode> ChildNodes => children;

        public override string OuterHTML
        {
            get
            {
                StringBuilder htmlBuilder = new StringBuilder();
                htmlBuilder.Append($"<{tagName}");

                if (cssClasses.Count > 0)
                {
                    htmlBuilder.Append(" class=\"");
                    htmlBuilder.Append(string.Join(" ", cssClasses));
                    htmlBuilder.Append("\"");
                }
                htmlBuilder.Append(">");

                foreach (var child in children)
                {
                    htmlBuilder.Append(child.OuterHTML);
                }

                htmlBuilder.Append($"</{tagName}>");

                return htmlBuilder.ToString();
            }
        }

        public override string InnerHTML
        {
            get
            {
                StringBuilder innerHtmlBuilder = new StringBuilder();
                foreach (var child in children)
                {
                    innerHtmlBuilder.Append(child.InnerHTML);
                }
                return innerHtmlBuilder.ToString();
            }
        }
    }
}
