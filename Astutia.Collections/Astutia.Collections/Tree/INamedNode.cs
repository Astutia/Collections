using System;
using System.Collections.Generic;
using System.Text;

namespace Astutia.Collections.Tree
{
    public interface INamedNode<TNode, TName> : INode<TNode> where TNode : INamedNode<TNode, TName>
    {
        TName Name
        {
            get;
        }

        TNode this[TName name]
        {
            get;
        }

        bool HasChild(TName name);
    }
}
