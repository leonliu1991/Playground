using System;
using System.Collections.Generic;
using System.Text;

namespace Playground
{
    public class AmazonInterview
    {
        LinkedList<string> linkedList = new LinkedList<string>();

        Dictionary<string, int> dic = new Dictionary<string, int>();

        public void NewUserLogin(string username)
        {
            if (linkedList.Contains(username))
            {
                linkedList.Remove(username);
                linkedList.AddLast(username);
                dic[username] += 1;
            }
            else
            {
                linkedList.AddLast(username);
                dic.Add(username, 1);
            }

            string first = linkedList.First.Value;
            string last = linkedList.Last.Value;
        }

        public string GetOldestOneTimeLoginUser()
        {
            string username = string.Empty;
            foreach(var node in linkedList)
            {
                if (dic[node] == 1)
                    return node;
            }

            return "No one time logic user at the moment.";
        }
    }
}
