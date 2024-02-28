using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace Playground
{
    public class Miscellanous
    {
        //LC 169
        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                if (!keyValuePairs.ContainsKey(num))
                    keyValuePairs.Add(num, 1);
                else
                {
                    keyValuePairs[num] += 1;
                }
            }

            int maxNum = keyValuePairs.Max(x => x.Value);

            return keyValuePairs.First(x => x.Value == maxNum).Key;
        }

        //LC 189
        public void Rotate(int[] nums, int k)
        {
            Array.Reverse(nums);
            Array.Reverse(nums, 0, k);
            Array.Reverse(nums, k, nums.Length - k);
        }

        //LC 58
        public int LengthOfLastWord(string s)
        {
                string[] results = s.Trim().Split(' ');
                return results[results.Length - 1].Length;
        }

        //LC 392
        public bool IsSubsequence(string s, string t)
        {
            Queue<char> queue = new Queue<char>();
            for (int i = 0; i < t.Length; i++)
            {
                queue.Enqueue(t[i]);
            }
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                while (queue.Count != 0)
                {
                    char a = queue.Dequeue();
                    if (a == s[i])
                    {
                        count++;
                        break;
                    }
                        
                }

            }

            if (count == s.Length)
                return true;
            else
                return false;
        }

        public bool IsPalindrome(string s)
        {
            Regex rgx = new Regex("[^a-zA-Z0-9]");
            s = rgx.Replace(s, "");
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - i - 1])
                    return false;
            }
            return true;
        }
        public long trappingWater(int[] arr, int n)
        {
            int a = 0;
            int b = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    a = i;
                    break;
                }
            }
            for (int i = n - 1; i > 0; i--)
            {
                if (arr[i] > arr[i - 1])
                {
                    b = i;
                    break;
                }
            }

            int height = Math.Min(arr[a], arr[b]);
            int sum = 0;
            for (int i = a + 1; i < b; i++)
            {
                sum += height - arr[i];
            }

            if (sum < 0)
                return 0;
            else
                return sum;
        }

    }
}
