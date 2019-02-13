using System;
using System.Collections.Generic;
using System.Text;
using Astutia.Collections.Storage;

namespace Astutia.Collections.Tree
{
    public abstract class NodeBase<TNode, TChildrenStorage> : INode<TNode, TChildrenStorage>
        where TNode : INode<TNode, TChildrenStorage>
        where TChildrenStorage : IReadonlyStorage<TNode>
    {
        private readonly TChildrenStorage childrenStorage;

        public NodeBase(TChildrenStorage childrenStorage)
        {
            if (childrenStorage == null)
            {
                throw new ArgumentNullException(nameof(childrenStorage));
            }

            this.childrenStorage = childrenStorage;
        }

        public TNode Parent
        {
            get;
            set;
        }

        public virtual TChildrenStorage ChildrenStorage
        {
            get
            {
                return this.childrenStorage;
            }
        }
    }
}
