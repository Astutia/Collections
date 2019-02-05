using System;
using System.Collections.Generic;
using System.Text;

namespace Astutia.Collections.Tree
{
    public class NodeWithValue<TNode, TName, TValue> : DictionaryNamedNodeBase<TNode, TName> where TNode : INodeWithValue<TNode, TName, TValue>
    {
        public NodeWithValue(IEqualityComparer<TName> comparer)
            : base(comparer)
        {
        }

        public NodeWithValue()
            : this(EqualityComparer<TName>.Default)
        {
        }

        public TValue Value
        {
            get;
            set;
        }
    }
}
