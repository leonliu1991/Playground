using System.Collections.Generic;
using System.Linq;
namespace Playground
{
    public static class FindMaximumNumberOfOccuringCharacterfromString
    {
        public static char ReturnMaxNumOfCharacterFromString(string s)
        {
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            int count = 0;
            char ans = '\0';
            for (int i = 0; i < s.Length; i++)
            {
                if (keyValuePairs.ContainsKey(s[i]))
                    keyValuePairs[s[i]]++;
                else
                    keyValuePairs.Add(s[i], 0);
            }

            int max = keyValuePairs.Values.Max();

            return keyValuePairs.First(x => x.Value == max).Key;
        }
    }
}
