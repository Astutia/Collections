using System.Collections.Generic;

namespace Astutia.Collections.Storage
{
    public interface IReadonlyDictionaryStorage<TKey, TValue> : IReadonlyStorage<TValue>
    {
        TValue this[TKey key]
        {
            get;
        }

        IEnumerable<TKey> Keys
        {
            get;
        }

        bool TryGetValue(TKey key, out TValue value);
    }
}
