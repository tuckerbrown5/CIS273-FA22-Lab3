using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace StringUtilities
{
    public static class StringUtilities
    {
        public static bool IsUniqueCharacterSet(this string s)
        {
            var cleanString = Regex.Replace(s, @"\s+" , "");

            HashSet<char> hashset = new HashSet<char>();

            foreach (var letter in cleanString.ToLower())
            {
                if (hashset.Contains(letter))
                {
                    return false;
                }

                hashset.Add(letter);
            }

            return true;
        }
    }
}
