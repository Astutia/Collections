using System;
using System.Collections.Generic;
using System.Text;
using Astutia.Collections.Storage;

namespace Astutia.Collections.Tree
{
    public interface INode<TNode, TChildrenStorage> 
        where TNode : INode<TNode, TChildrenStorage>
        where TChildrenStorage : IReadonlyStorage<TNode>
    {
        TNode Parent
        {
            get;
        }

        TChildrenStorage ChildrenStorage
        {
            get;
        }
    }
}
