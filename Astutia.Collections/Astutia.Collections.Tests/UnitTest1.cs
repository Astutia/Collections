using System.Collections.Generic;
using Astutia.Collections.Storage;
using Astutia.Collections.Tree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Astutia.Collections.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IMyNode<string, string> node = new MyNode<string, string>() { Value = "Elo :D" };
            
        }
    }

    public interface IMyNode<TKey, TValue> : INode<IMyNode<TKey, TValue>, IDictionaryStorage<TKey, IMyNode<TKey, TValue>>>
    {
    }

    public class MyNode<TKey, TValue> : NodeBase<IMyNode<TKey, TValue>, IDictionaryStorage<TKey, IMyNode<TKey, TValue>>>,
                                        IMyNode<TKey, TValue>
    {
        public MyNode()
            : base(new DictionaryStorage<TKey, IMyNode<TKey, TValue>>())
        {
        }

        public TValue Value { get; set; }
    }
}
