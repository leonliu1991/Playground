using System;
using System.Collections.Generic;
using System.Text;

namespace Playground
{
    public static class Permutations
    {
        public static IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            List<int> path = new List<int>();
            BackTracking(nums, path, result);
            return result;
        }

        public static void BackTracking(int[] nums, List<int> path, IList<IList<int>> result)
        {
            if (path.Count == nums.Length)
            {
                result.Add(new List<int>(path));
                return;
            }

            for(int i = 0; i < nums.Length; i++)
            {
                if (path.Contains(nums[i]))
                    continue;
                path.Add(nums[i]);
                BackTracking(nums, path, result);
                path.RemoveAt(path.Count - 1);

            }
        }

        public static IList<IList<int>> Combine(int n, int k)
            {
                List<int> temp = new List<int>();
                IList<IList<int>> result = new List<IList<int>>();
                BackTrackingg(temp, result, n, k, 1);
                return result;
            }

            private static void BackTrackingg(List<int> temp, IList<IList<int>> result, int n, int k, int start)
            {
                if(temp.Count == k)
                {
                    result.Add(new List<int>(temp));
                    return;
                }

                for(int i = start; i <= n; i++)
                {
                    if (temp.Contains(i)) continue;
                    temp.Add(i);
                    BackTrackingg(temp, result, n, k, i+1);
                    temp.RemoveAt(temp.Count - 1);
                }
            }
    }
}
