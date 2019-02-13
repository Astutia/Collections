using System;
using System.Collections.Generic;
using System.Text;

namespace Astutia.Collections.Storage
{
    public interface IStorage<TValue> : IReadonlyStorage<TValue>
    {
        IStorage<TValue> Add(TValue data);

        IStorage<TValue> Add(IEnumerable<TValue> data);
    }
}
