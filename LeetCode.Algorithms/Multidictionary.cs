using System.Collections.Generic;

namespace Algorithms
{
    public class Multidictionary<K, V>
    {
        private Dictionary<K, List<V>> dictionary;

        public Multidictionary()
        {
            dictionary = new Dictionary<K, List<V>>();
        }

        public void Add(K k, V v)
        {
            List<V> list;
            dictionary.TryGetValue(k, out list);
            if (list == null)
            {
                list = new List<V>();
                dictionary.Add(k, list);
            }
            list.Add(v);
        }

        public IEnumerable<K> Keys { get { return dictionary.Keys; } }

        public IEnumerable<IEnumerable<V>> Values
        {
            get { return dictionary.Values; }
        }
    }
}
