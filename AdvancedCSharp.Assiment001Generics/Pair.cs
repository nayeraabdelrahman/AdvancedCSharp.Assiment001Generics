using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCSharp.Assiment001Generics
{
    internal class Pair<TKey,TValue>
    {
        public TKey key { set; get; }
        public TValue value { set; get; }

        public Pair(TKey key, TValue value)
        {
            this.key = key;
            this.value = value;
        }
    }
}
