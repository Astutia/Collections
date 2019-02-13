using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Astutia.Collections.Storage;

namespace Astutia.Collections.Tree
{
    public static class TreeExtensions
    {
        public static bool IsLeaf<TNode, TChildrenStorage>(this TNode node) 
            where TNode : INode<TNode, TChildrenStorage>
            where TChildrenStorage : IReadonlyStorage<TNode>
        {
            return node.ChildrenCount<TNode, TChildrenStorage>() == 0;
        }

        public static bool IsRoot<TNode, TChildrenStorage>(this TNode node)
            where TNode : INode<TNode, TChildrenStorage>
            where TChildrenStorage : IReadonlyStorage<TNode>
        {
            return object.Equals(node.Parent, default(TNode));
        }

        public static TNode Root<TNode, TChildrenStorage>(this TNode node) 
            where TNode : INode<TNode, TChildrenStorage>
            where TChildrenStorage : IReadonlyStorage<TNode>
        {
            if (node == null)
            {
                return default(TNode);
            }

            TNode current = node;

            while (true)
            {
                if (current.Parent == null)
                {
                    return current;
                }

                current = current.Parent;
            }
        }

        public static IEnumerable<TNode> Siblings<TNode, TChildrenStorage>(this TNode node)
            where TNode : INode<TNode, TChildrenStorage>
            where TChildrenStorage : IReadonlyStorage<TNode>
        {
            if (node.IsRoot<TNode, TChildrenStorage>())
            {
                return Enumerable.Empty<TNode>();
            }

            return node.Parent.ChildrenStorage.Values.Where(sibling => !object.Equals(sibling, node));
        }

        public static int ChildrenCount<TNode, TChildrenStorage>(this TNode node)
            where TNode : INode<TNode, TChildrenStorage>
            where TChildrenStorage : IReadonlyStorage<TNode>
        {
            return node == null
                    ? 0
                    : node.ChildrenStorage.Count;
        }

        /*public static TNode AddChild<TNode, TChildrenStorage>(this TNode node, TNode child)
            where TNode : INode<TNode, TChildrenStorage>
            where TChildrenStorage : IStorage<TNode>
        {
            if (child.Parent != null)
            {
                throw new InvalidOperationException("The child already has a parent node.");
            }

            child.Parent = node;
            return node;
        }*/
    }
}
