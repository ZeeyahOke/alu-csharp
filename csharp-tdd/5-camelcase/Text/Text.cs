using System;

namespace Text
{
    /// <summary>
    /// Provides string utility operations.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Counts the number of words in a camelCase string.
        /// Each word after the first begins with a capital letter.
        /// </summary>
        /// <param name="s">A camelCase string.</param>
        /// <returns>Number of words in s.</returns>
        public static int CamelCase(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            // Start with 1 word (the first word has no leading capital)
            int count = 1;
            foreach (char c in s)
                if (char.IsUpper(c))
                    count++;

            return count;
        }
    }
}
