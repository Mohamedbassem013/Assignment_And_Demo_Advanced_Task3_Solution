using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Advanced_C__Task3.part_01.Question_1
{
    internal class Helper
    {
        public static int FindTheFirstNonRepeatedCharIndex(string str)
        {
            if (string.IsNullOrEmpty(str))
                return -1;

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (charCount[str[i]] == 1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
