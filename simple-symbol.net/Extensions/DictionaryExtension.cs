using System;
using System.Collections.Generic;

namespace simple.symbol.net.Extensions
{
    public static class DictionaryExtension
    {
        /// <summary>
        /// Find key or return value
        /// </summary>
        /// <param name="table"></param>
        /// <param name="key"></param>
        /// <param name="default"></param>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <returns></returns>
        public static TValue FindOrElse<TKey, TValue>(this IDictionary<TKey, TValue> table, TKey key, Func<TValue> @default)
        {
            return table.ContainsKey(key) ? table[key] : @default();
        }
    }
}