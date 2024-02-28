using System;

namespace Playground
{
    public class TreeNode2
    {
        public int data;
        public TreeNode2 left;
        public TreeNode2 right;

        public TreeNode2(int d)
        {
            data = d;
        }
    }
    public class BinaryTree
    {
        public TreeNode2 root;
        public void MirrorTree()
        {
            this.root = MirrorTree(root);
        }

        public TreeNode2 MirrorTree(TreeNode2 node)
        {
            if (node == null)
                return node;
            TreeNode2 left = MirrorTree(node.left);
            TreeNode2 right = MirrorTree(node.right);

            node.left = right;
            node.right = left;

            return node;
        }

        public void PrintTree()
        {
            PrintTree(root);
        }
        public void PrintTree(TreeNode2 node)
        {
            if (node == null)
                return;

            PrintTree(node.left);
            Console.Write(node.data + " ");
            PrintTree(node.right);
        }

        public int MaxDepth(TreeNode2 root)
        {
            if (root == null)
                return 0;

            int left = MaxDepth(root.left);
            int right = MaxDepth(root.right);

            return Math.Max(left, right) + 1;
        }
    }
}
