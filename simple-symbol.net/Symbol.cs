using System;
using System.Collections.Concurrent;
using simple.symbol.net.Extensions;
using static simple.symbol.net.Utilities.HashUtility;

namespace simple.symbol.net
{
    [Serializable]
    public class Symbol
    {
        // ReSharper disable once ConvertToAutoPropertyWithPrivateSetter
        public string Value => _value;

        /// <summary>
        /// Reference of all symbols so far
        /// </summary>
        private static readonly ConcurrentDictionary<int, Symbol> Table = new ConcurrentDictionary<int, Symbol>();

        /// <summary>
        /// Raw value of symbol
        /// </summary>
        private readonly string _value;

        /// <summary>
        /// Instantiate or returns existing symbol
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Symbol Of(string value) => Table.FindOrElse(StringHashCode(value), () => new Symbol(value));

        /// <summary>
        /// Has to be private
        /// </summary>
        private Symbol() { }
        
        /// <summary>
        /// Private constructor
        /// </summary>
        /// <param name="value"></param>
        private Symbol(string value)
        {
            _value = value;

            Table[StringHashCode(value)] = this;
        }

        /// <summary>
        /// Returns string representation of Symbol
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("'{0}", _value);
        }

        /// <summary>
        /// Returns boolean indicating Symbols are equal or not
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            switch (obj)
            {
                case Symbol other:
                    return StringHashCode(_value) == StringHashCode(other._value);
                default:
                    return false;
            }
        }

        /// <summary>
        /// Returns the hashcode using MD5 of raw value
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return StringHashCode(_value);
        }
    }
}