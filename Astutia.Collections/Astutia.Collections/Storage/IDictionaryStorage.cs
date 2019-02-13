using System;
using System.Collections.Generic;
using System.Text;

namespace Astutia.Collections.Storage
{
    public interface IDictionaryStorage<TKey, TValue> : IReadonlyDictionaryStorage<TKey, TValue>
    {
        new TValue this[TKey key]
        {
            get;
            set;
        }
    }
}
