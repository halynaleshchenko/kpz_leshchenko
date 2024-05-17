using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console3
{
    public class LightElementNode : LightNode
    {
        private string tagName;
        private List<string> cssClasses;
        private List<LightNode> children;
        private Dictionary<string, List<Action>> eventListeners;

        public LightElementNode(string tagName, string displayType, string closingType, List<string> cssClasses, List<LightNode> children)
        {
            this.tagName = tagName;
            this.cssClasses = cssClasses;
            this.children = children;
            this.eventListeners = new Dictionary<string, List<Action>>();
        }

        public void AddEventListener(string eventName, Action listener)
        {
            if (!eventListeners.ContainsKey(eventName))
            {
                eventListeners[eventName] = new List<Action>();
            }
            eventListeners[eventName].Add(listener);
        }


        public void TriggerEvent(string eventName)
        {
            if (eventListeners.ContainsKey(eventName))
            {
                foreach (var listener in eventListeners[eventName])
                {
                    listener();
                }
            }
        }

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
