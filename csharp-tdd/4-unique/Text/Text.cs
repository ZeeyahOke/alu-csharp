using System;
using System.Collections.Generic;

namespace Text
{
    /// <summary>
    /// Provides string utility operations.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Returns the index of the first non-repeating character in a string.
        /// </summary>
        /// <param name="s">The input string (lowercase letters only).</param>
        /// <returns>Index of first unique character, or -1 if none exists.</returns>
        public static int UniqueChar(string s)
        {
            if (string.IsNullOrEmpty(s))
                return -1;

            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (counts.ContainsKey(c))
                    counts[c]++;
                else
                    counts[c] = 1;
            }

            for (int i = 0; i < s.Length; i++)
                if (counts[s[i]] == 1)
                    return i;

            return -1;
        }
    }
}
