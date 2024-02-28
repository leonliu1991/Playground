using System;
using System.Collections.Generic;
using System.Text;

namespace Playground
{
    public class LRUCache
    {
        private readonly int capacity;
        private readonly Dictionary<int, LinkedListNode<CacheItem>> cacheMap;
        private readonly LinkedList<CacheItem> cacheList;
        private class CacheItem
        {
            public int Key { get; }
            public int Value { get; set; }

            public CacheItem(int key, int value)
            {
                Key = key;
                Value = value;
            }
        }
        public LRUCache(int capacity)
        {
            this.capacity = capacity;
            cacheMap = new Dictionary<int, LinkedListNode<CacheItem>>(capacity);
            cacheList = new LinkedList<CacheItem>();
        }

        public int Get(int key)
        {
            if (cacheMap.TryGetValue(key, out var node))
            {
                cacheList.Remove(node);
                cacheList.AddFirst(node);

                return node.Value.Value;
            }
            return -1;
        }

        public void Put(int key, int value)
        {
            if (cacheMap.TryGetValue(key, out var node))
            {
                node.Value.Value = value;
                cacheList.Remove(node);
                cacheList.AddFirst(node);
            }
            else
            {
                if (cacheMap.Count >= capacity)
                {
                    var lastNode = cacheList.Last;
                    cacheMap.Remove(lastNode.Value.Key);
                    cacheList.RemoveLast();
                }

                var newNode = new LinkedListNode<CacheItem>(new CacheItem(key, value));
                cacheMap.Add(key, newNode);
                cacheList.AddFirst(newNode);
            }
        }

        public List<int> subarraySum(List<int> arr, int n, long s)
        {
            int sum = 0;
            List<int> results = new List<int>();
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    sum += arr[j];
                    if (sum == s)
                    {
                        results.Add(i + 1);
                        results.Add(j + 1);
                        return results;
                    }
                }
                sum = 0;
            }

            results.Add(-1);
            return results;
        }

        public int equilibriumPoint(long[] a, int n)
        {
            long sum = 0;
            long prefix = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            for (int i = 0; i < a.Length; i++)
            {
                if (prefix == sum - a[i] - prefix)
                    return i + 1;
                else
                {
                    prefix += a[i];
                }
            }

            return -1;
        }
    }
}
