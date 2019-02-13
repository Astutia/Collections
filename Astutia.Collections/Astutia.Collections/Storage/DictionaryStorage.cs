using System;
using System.Collections.Generic;
using System.Text;

namespace Astutia.Collections.Storage
{
    public class DictionaryStorage<TKey, TValue> : IDictionaryStorage<TKey, TValue>
    {
        private readonly Dictionary<TKey, TValue> data;

        public DictionaryStorage(IEqualityComparer<TKey> comparer = null, int capacity = 0)
        {
            this.data = new Dictionary<TKey, TValue>(capacity, comparer ?? EqualityComparer<TKey>.Default);
        }

        public TValue this[TKey key]
        {
            get => this.TryGetValue(key, out TValue value)
                    ? value
                    : default(TValue);
            set => this.data[key] = value;
        }

        public IEnumerable<TKey> Keys => this.data.Keys;

        public IEnumerable<TValue> Values => this.data.Values;

        public int Count => this.data.Count;

        public bool TryGetValue(TKey key, out TValue value) => this.data.TryGetValue(key, out value);
    }
}
