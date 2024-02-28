
using System;
using System.Collections.Generic;
using System.Linq;

namespace Playground
{
    public class TreeNode
    {
        public int key { get; set; }
        public string value { get; set; }
        public int val { get; set; }

        public TreeNode left { get; set; }
        public TreeNode right { get; set; }

        public TreeNode(int Key, string Value, int val)
        {
            this.key = Key;
            this.value = Value;
            this.val = val;
        }
    }

    public class BinarySearchTree
    {
        public TreeNode Root { get; set; } = null;

        public void Insert(int key, string value)
        {
            Root = InsertItem(Root, key, value);
        }

        public TreeNode InsertItem(TreeNode node, int key, string value)
        {
            TreeNode newNode = new TreeNode(key, value, key);
            if (node == null)
            {
                node = newNode;
                return node;
            }

            if (key < node.key)
            {
                node.left = InsertItem(node.left, key, value);
            }
            else
            {
                node.right = InsertItem(node.right, key, value);
            }

            return node;
        }

        public string Find(int key)
        {
            TreeNode node = Find(Root, key);
            return node == null ? null : node.value;
        }

        public TreeNode? Find(TreeNode node, int key)
        {
            if (node == null || node.key == key)
            {
                return node;
            }

            if (key < node.key)
            {
                node = Find(node.left, key);

            }
            else
                node = Find(node.right, key);

            return node;
        }

        public IList<double> AverageOfLevels(TreeNode root)
        {
            if (root == null)
                return new List<double>() { 0 };
            if (root.left == null && root.right == null)
                return new List<double>() { root.val };

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            List<double> results = new List<double>();

            while (queue.Any())
            {
                int count = queue.Count();
                double sum = 0;

                for (int i = 0; i < count; i++)
                {
                    TreeNode node = queue.Dequeue();
                    sum += node.val;

                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                }

                results.Add(sum / count);
            }

            return results;
        }

        public int GetDepthOfATree(TreeNode root)
        {
            if (root == null) return 0;
            int height = 0;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (true)
            {
                int nodeCount = queue.Count;
                if (nodeCount == 0)
                    return height;
                height++;

                while (nodeCount > 0)
                {
                    TreeNode node = queue.Peek();
                    queue.Dequeue();
                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                    nodeCount--;
                }
                
            }
        }

        public int GetMinimumDifference_wrongSolution(TreeNode root)
        {
            if (root == null)
                return 0;
            List<int> resultList = new List<int>();

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Any())
            {
                TreeNode node = queue.Dequeue();
                if (node.left != null)
                {
                    resultList.Add(Math.Abs(node.val - node.left.val));
                    queue.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    resultList.Add(Math.Abs(node.val - node.right.val));
                    queue.Enqueue(node.right);
                }

                int min = resultList.Min();
                resultList.Clear();
                resultList.Add(min);
            }

            return resultList.Min();
        }
        public int GetMinimumDifference(TreeNode root)
        {
            InorderTraversal(root);
            int min = int.MaxValue;
            for(int i= 0; i < list.Count-1; i++)
            {
                min = Math.Min(min, Math.Abs(list[i] - list[i + 1]));
            }
            return min;
        }

        public List<int> list = new List<int>();
        public void InorderTraversal(TreeNode root)
        {
            if (root == null)
                return;

            InorderTraversal(root.left);
            list.Add(root.val);
            InorderTraversal(root.right);
        }

    }
}
