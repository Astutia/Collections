using System;
using System.Collections.Generic;
using System.Text;

namespace Astutia.Collections.Tree
{
    public interface INode<TNode> where TNode : INode<TNode>
    {
        TNode Parent
        {
            get;
        }

        IEnumerable<TNode> Children
        {
            get;
        }

        int Count
        {
            get;
        }
    }
}
