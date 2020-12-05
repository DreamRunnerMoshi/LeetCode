using System;
using System.Collections;
using System.Collections.Generic;

namespace ProgramClient
{
    public class _146LRUCache
    {

        private Queue cache;
        private readonly int capacity;
        private Dictionary<int, int> dict;

        public _146LRUCache(int capacity)
        {
            this.capacity = capacity;
            cache = new Queue();
            dict = new Dictionary<int, int>();
        }

        public int get(int key)
        {
            if (cache.Count == 0) return -1;
            if (!dict.ContainsKey(key)) return -1;

            return dict[key];
        }

        public void put(int key, int value)
        {
            if (cache.Count == capacity)
            {
                var leastKey = (int)cache.Dequeue();
                Console.WriteLine(leastKey);
                dict.Remove(leastKey);
            }

            dict.Add(key, value);
            cache.Enqueue(key);
        }
    }
}
