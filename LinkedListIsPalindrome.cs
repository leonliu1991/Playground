using System;
using System.Collections.Generic;

namespace Playground
{
    public class Node
    {
        public string data;
        public Node next;

        public Node(string d)
        {
            data = d;
            next = null;
        }
    }
    public class LinkedListIsPalindrome
    {
        public Node head;

        public bool IsPalindrome()
        {
            Node node = head;
            String str = "";
            while (node != null)
            {
                str += node.data;
                node = node.next;
            }

            return IsPalindromeUtl(str);
        }

        public bool IsPalindromeUtl(string str)
        {
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                    return false;
            }

            return true;
        }

        public bool HasCycle(Node head)
        {
            HashSet<Node> vistedNodeList = new HashSet<Node>();
            Node currentNode = head;
            while (currentNode.next != null)
            {
                if (vistedNodeList.Contains(currentNode))
                    return true;
                vistedNodeList.Add(currentNode.next);
                currentNode = currentNode.next;
            }
            return false;
        }

        //The typical "Hare and Tortoise" algorithm, if there is a circle, fast node will eventually
        //catch up the slow node
        public bool HasCycle2(Node head)
        {
            Node slowNode = head;
            Node fastNode = head;
            while(fastNode != null && fastNode.next != null)
            {
                slowNode = slowNode.next;
                fastNode = fastNode.next.next;

                if (slowNode == fastNode)
                    return true;
            }
            return false;
        }

        public class TreeNode
        {
          public int val;
          public TreeNode left;
          public TreeNode right;
          public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
          {
            this.val = val;
            this.left = left;
            this.right = right;
          }
         }

        public class Solution
        {
            public int MaxDepth(TreeNode root)
            {
                if (root == null)
                    return 0;

                int left = MaxDepth(root.left);
                int right = MaxDepth(root.right);

                return Math.Max(left, right) + 1;
            }
        }

    }
    
}


