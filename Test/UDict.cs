using System;
using System.Collections.Generic;

namespace Test
{
	public class UDict<TKey, TVal>
	{

		Dictionary<TKey, TVal> dict = new Dictionary<TKey, TVal>();

		public UDict(params object[] kv) {
		
		}

		public void Add(TKey key, TVal val)
		{
			if (key.GetType () != typeof(TKey))
				throw new ArgumentException ("key {0} is not type of {1}".Format (key.GetType ().Name, typeof(TKey).Name));
			if (val.GetType () != typeof(TVal))
				throw new ArgumentException ("value {0} is not type of {1}".Format (val.GetType ().Name, typeof(TKey).Name));
			this.dict.Add (key, val);
		}

		public void AddMatch(params object[] kv)
		{
			if (kv % 2 != 1)
				throw new ArgumentException ("kv.Length must be devide by 2, (is k,v,k,v,k,v)");
			for (int i = 0; i < kv.Length; i += 2)
				this.Add (kv [i], kv [i + 1]);
		}




	}
}

