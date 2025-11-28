using System;

namespace Program
{
    internal class Program
    {
        public static bool IsValid(string str)
        {
            if (str == null || str.Length % 2 != 0)
            {
                return false;
            }

            string prev;
            do // Using do-while cause the first iteration is false already
            {
                prev = str;
                str = RemovePairs(str); // Remove all valid pairs
            }
            while (str != prev); // Repeat until no more pairs can be removed

            return str.Length == 0; // If string is empty, all pairs were valid
        }

        private static string RemovePairs(string s)
        {
            string result = "";
            int i = 0;

            while (i < s.Length)
            {
                // Check next two characters for valid pair
                if (i < s.Length - 1 &&
                    ((s[i] == '(' && s[i + 1] == ')') ||
                     (s[i] == '[' && s[i + 1] == ']') ||
                     (s[i] == '{' && s[i + 1] == '}')))
                {
                    // Removing the pair, so skip both characters
                    i += 2;
                }
                else
                {
                    // Keep the character
                    result += s[i];
                    i++;
                }
            }
            return result; // Return the string without valid pairs
        }

        static void Main(string[] args)
        {
            string str1 = "({[]})"; // Valid string
            string str2 = "({[})]"; // Invalid string
            Console.WriteLine($"{str1} string is valid: {IsValid(str1)}.");
            Console.WriteLine($"{str2} string is valid: {IsValid(str2)}.");
        }
    }
}