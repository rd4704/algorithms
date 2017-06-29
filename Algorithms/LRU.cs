using System;
namespace Algorithms
{
	using System.Collections.Generic;
	using System.Collections.Specialized;

	public class LRU
	{
		LRUCacheHelper<int, int> lru;

		public LRU(int capacity)
		{
			lru = new LRUCacheHelper<int, int>(capacity);
		}

		public int Get(int key)
		{
			int val = -1;
			try
			{
				val = lru.Get(key);
			}
			catch (Exception ex)
			{
			}

			return val;
		}

		public void Put(int key, int value)
		{
			lru.Add(key, value);
		}
	}

	public class LRUCacheHelper<K, V>
	{
		readonly Dictionary<K, V> _dict;
		readonly LinkedList<K> _queue = new LinkedList<K>();
		readonly object _syncRoot = new object();
		readonly int _max;
		public LRUCacheHelper(int capacity)
		{
			_dict = new Dictionary<K, V>(capacity);
			_max = capacity;
		}

		public void Add(K key, V value)
		{
			lock (_syncRoot)
			{
				CheckCapacity();
				_queue.AddLast(key);                            //O(1)
				_dict[key] = value;                             //O(1)
			}
		}

		void CheckCapacity()
		{
			lock (_syncRoot)
			{
				int count = _dict.Count;                        //O(1)
				if (count == _max)
				{
					// cache full, so re-use the oldest node
					var node = _queue.First;
					_dict.Remove(node.Value);                   //O(1)
					_queue.RemoveFirst();                       //O(1)
				}
			}
		}

		public void Delete(K key)
		{
			lock (_syncRoot)
			{
				_dict.Remove(key);                              //O(1)
				_queue.Remove(key);                             //O(n)
			}
		}

		public V Get(K key)
		{
			lock (_syncRoot)
			{
				V ret;
				if (_dict.TryGetValue(key, out ret))            //O(1)
				{
					_queue.Remove(key);                         //O(n)
					_queue.AddLast(key);                        //O(1)
				}
				return ret;
			}
		}
	}
}


/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */
