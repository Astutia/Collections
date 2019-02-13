using System;
using System.Collections.Generic;
using System.Text;

namespace Astutia.Collections.Storage
{
    public interface IReadonlyStorage<TValue>
    {
        IEnumerable<TValue> Values
        {
            get;
        }

        int Count
        {
            get;
        }
    }
}
