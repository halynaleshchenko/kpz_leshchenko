using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console5
{
    public class LightNodeIterator : IEnumerable<LightNode>
    {
        private LightNode rootNode;

        public LightNodeIterator(LightNode rootNode)
        {
            this.rootNode = rootNode;
        }

        public IEnumerator<LightNode> GetEnumerator()
        {
            return TraverseInDepth(rootNode).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private IEnumerable<LightNode> TraverseInDepth(LightNode node)
        {
            yield return node;
            if (node is LightElementNode elementNode)
            {
                foreach (var child in elementNode.ChildNodes)
                {
                    foreach (var descendant in TraverseInDepth(child))
                    {
                        yield return descendant;
                    }
                }
            }
        }

        private IEnumerable<LightNode> TraverseInWidth(LightNode node)
        {
            Queue<LightNode> queue = new Queue<LightNode>();
            queue.Enqueue(node);
            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                yield return current;
                if (current is LightElementNode elementNode)
                {
                    foreach (var child in elementNode.ChildNodes)
                    {
                        queue.Enqueue(child);
                    }
                }
            }
        }
    }
}
