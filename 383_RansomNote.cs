using System.Collections.Generic;

namespace Playground
{
    class RansomNote
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (magazine.Contains(ransomNote[i]))
                {
                    magazine = magazine.Remove(ransomNote[i]);
                }
                else
                    return false;
            }
            return true;
        }

        public bool CanConstructOption2(string ransomNote, string magazine)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (int i = 0; i < magazine.Length; i++)
            {
                if (map.ContainsKey(magazine[i]))
                    map[magazine[i]]++;
                else
                    map.Add(magazine[i], 1);
            }

            for (int i = 0; i < ransomNote.Length; i++)
            {
                map.Add(ransomNote[i], map[ransomNote[i]]++);

                if (!map.ContainsKey(ransomNote[i]) || map[ransomNote[i]] == 0)
                    return false;
            }

            return true;
        }
    }
}
