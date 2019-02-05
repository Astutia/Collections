using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Astutia.Collections.Tree
{
    public static class TreeExtensions
    {
        public static bool IsLeaf<TNode>(this TNode node) where TNode : INode<TNode>
        {
            return node != null
                   && node.Count == 0;
        }

        public static TNode Root<TNode>(this TNode node) where TNode : INode<TNode>
        {
            if (node == null)
            {
                return default(TNode);
            }

            TNode current = node;

            while (true)
            {
                if (node.Parent == null)
                {
                    return node;
                }

                current = current.Parent;
            }
        }

        public static TNode GetChild<TNode, TName>(this TNode node, TName name) where TNode : INamedNode<TNode, TName>
        {
            return node[name];
        }
    }
}
