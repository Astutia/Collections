using System.Collections.Generic;
using Astutia.Collections.Tree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Astutia.Collections.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IMyNode<string> node = new MyNode<string>() { Value = "elo :D", Name = 1 };
        }
    }

    public interface IMyNode<TValue> : INodeWithValue<IMyNode<TValue>, int, TValue>
    {
    }

    public class MyNode<TValue> : NodeWithValue<IMyNode<TValue>, int, TValue>,
                                  IMyNode<TValue>
    {
    }
}
