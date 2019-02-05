using System;
using System.Collections.Generic;
using System.Text;

namespace Astutia.Collections.Tree
{
    public interface INodeWithValue<TNode, TName, TValue> : INamedNode<TNode, TName> where TNode : INodeWithValue<TNode, TName, TValue>
    {
        TValue Value
        {
            get;
        }
    }
}
