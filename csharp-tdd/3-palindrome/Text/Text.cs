using System;
using System.Text.RegularExpressions;

namespace Text
{
    /// <summary>
    /// Provides string utility operations.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Determines whether a string is a palindrome.
        /// Case-insensitive; spaces and punctuation are ignored.
        /// An empty string is considered a palindrome.
        /// </summary>
        /// <param name="s">The string to check.</param>
        /// <returns>True if s is a palindrome, False otherwise.</returns>
        public static bool IsPalindrome(string s)
        {
            if (s == null || s.Length == 0)
                return true;

            // Remove non-alphanumeric characters and convert to lowercase
            string clean = Regex.Replace(s.ToLower(), "[^a-z0-9]", "");

            if (clean.Length == 0)
                return true;

            int left = 0;
            int right = clean.Length - 1;
            while (left < right)
            {
                if (clean[left] != clean[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }
    }
}
