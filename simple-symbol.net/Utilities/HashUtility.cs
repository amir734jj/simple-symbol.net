using System;
using System.Linq;
using System.Text;

namespace simple.symbol.net.Utilities
{
    public static class HashUtility
    {
        /// <summary>
        /// Retruns the MD5 of string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int StringHashCode(string str)
        {
            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                var input = Encoding.ASCII.GetBytes(str);
                var output = md5.ComputeHash(input).Take(7).ToArray();

                return BitConverter.ToInt32(output, 0);
            }
        }
    }
}