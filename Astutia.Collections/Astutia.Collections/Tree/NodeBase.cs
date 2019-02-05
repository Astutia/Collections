using System;
using System.Collections.Generic;
using System.Text;

namespace Astutia.Collections.Tree
{
    public abstract class NodeBase<TNode> : INode<TNode> where TNode : INode<TNode>
    {
        public TNode Parent
        {
            get;
            private set;
        }

        public abstract IEnumerable<TNode> Children
        {
            get;
        }

        public abstract int Count
        {
            get;
        }
    }
}
