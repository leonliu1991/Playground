namespace Playground
{
    public class LongestParenthsis
    {
        public int LongestValidParentheses(string s)
        {
            int count = 0;

            char[] s1 = s.ToCharArray();
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == '(')
                {
                    if (s1[i + 1] == ')')
                        count += 2;
                }

            }

            return count;
        }
    }
}
