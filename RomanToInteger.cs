using System;
using System.Collections.Generic;

namespace Playground
{
    public class RomanToInteger
    {
        public int ConvertRomanToInteger(string s)
        {
            int num = 0;
            Dictionary<char, int> map = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            for (int i = 0; i < s.Length; i++)
            {
                if (s.Length == 0 || i == s.Length - 1)
                {
                    num += map[s[i]]; break;
                }

                if (map[s[i]] < map[s[i + 1]])
                {
                    num += map[s[i + 1]] - map[s[i]];
                    i++;
                }
                else
                    num += map[s[i]];
            }

            return num;
        }

        public bool IsIsomorphic(string s, string t)
        {
            Dictionary<char, char> map = new Dictionary<char, char>();
            for(int  i = 0; i < s.Length; i++)
            {
                if(map.TryGetValue(s[i], out var currentValue))
                {
                    if (currentValue != t[i])
                        return false;
                }
                if (map.ContainsValue(t[i]))
                    return false;
                map.Add(s[i], t[i]);

            }

            return true;
        }

        public string ReverseWords(string s)
        {
            string[] afterSplit = s.Split(' ');
            Array.Reverse(afterSplit);
            string results = string.Empty;
            foreach (string str in afterSplit)
            {
                if (str == " ")
                    continue;
                results += str + " ";
            }
            return results.Trim();
        }

        //Leetcode 121 Best time to buy and sell the stock
        public class CalculateMaxProfit
        {
            public int MaxProfit(int[] prices)
            {
                int difference;
                int temp = 0;
                for (int i = 0; i < prices.Length; i++)
                {
                    for (int j = i + 1; j < prices.Length; j++)
                    {
                        difference = prices[j] - prices[i];
                        if (difference >= temp)
                            temp = difference;
                    }
                }

                return temp;
            }

            public int MaxProfit2(int[] prices)
            {
                int smallest = int.MaxValue;
                int profitIfSoldToday = 0;
                int overallProfit = 0;

                for(int i = 0; i < prices.Length; i++)
                {
                    if (prices[i] < smallest)
                        smallest = prices[i];

                    profitIfSoldToday = prices[i] - smallest;

                    if (profitIfSoldToday > overallProfit)
                        overallProfit = profitIfSoldToday;
                }

                return overallProfit;
            }

            
        }
    }
}
