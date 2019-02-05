using System;
using System.Collections.Generic;
using System.Text;

namespace Astutia.Collections.Tree
{
    public abstract class DictionaryNamedNodeBase<TNode, TName> : NodeBase<TNode> where TNode : INamedNode<TNode, TName>
    {
        private readonly Dictionary<TName, TNode> children;

        public DictionaryNamedNodeBase(IEqualityComparer<TName> comparer)
        {
            this.children = new Dictionary<TName, TNode>(comparer ?? throw new ArgumentNullException(nameof(comparer)));
        }

        public DictionaryNamedNodeBase()
            : this(EqualityComparer<TName>.Default)
        {
        }

        public override IEnumerable<TNode> Children => this.children.Values;

        public override int Count => this.children.Count;

        public virtual TName Name
        {
            get;
            set;
        }

        public TNode this[TName name]
        {
            get
            {
                return this.children.TryGetValue(name, out TNode child)
                         ? child
                         : default(TNode);
            }
        }

        public bool HasChild(TName name)
        {
            return this.children.ContainsKey(name);
        }
    }
}
