using Microsoft.VisualStudio.TestTools.UnitTesting;
using Playground;
using System;
using System.Collections.Generic;

[TestClass]
public class PlayGround
{
    [TestMethod]
    public void TestTreeNode()
    {
        BinarySearchTree bst = new BinarySearchTree();
        bst.Insert(7, "Squirtle");
        bst.Insert(23, "Ekans");
        bst.Insert(151, "Mew");
        bst.Insert(4, "Charmander");
        bst.Insert(1, "Bulbasaur");

        Console.WriteLine("Found: " + bst.Find(9));
    }

    [TestMethod]
    public void TestLinkedListIsPalindrome()
    {
        LinkedListIsPalindrome list = new LinkedListIsPalindrome();
        list.head = new Node("a");
        list.head.next = new Node("bc");
        list.head.next.next = new Node("de");
        list.head.next.next.next = new Node("dcb");
        list.head.next.next.next.next = new Node("a");

        Assert.IsTrue(list.IsPalindrome());

        LinkedList<string> a = new LinkedList<string>();
    }

    [TestMethod]
    public void TestMirrorBinaryTree()
    {
        BinaryTree tree = new BinaryTree();
        tree.root = new TreeNode2(1);
        tree.root.left = new TreeNode2(2);
        tree.root.right = new TreeNode2(3);
        tree.root.left.left = new TreeNode2(4);
        tree.root.left.right = new TreeNode2(5);
        tree.root.left.left.left = new TreeNode2(6);

        tree.PrintTree();
        Console.WriteLine(" ");
        tree.MirrorTree();
        tree.PrintTree();

        int i = tree.MaxDepth(tree.root);
    }

    [TestMethod]
    public void TestRotateImageBy90Degree()
    {
        int[,] num = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        Rotate2DArray a = new Rotate2DArray(num);

        a.RotateBy90DegreeAntiClockwise();
        Console.WriteLine(a.ToString());
    }

    [TestMethod]
    public void TestMaxNumberOfCharacterOfString()
    {
        string s = "fever dream high in the quite of the night".Replace(" ", string.Empty);

        char c = FindMaximumNumberOfOccuringCharacterfromString.ReturnMaxNumOfCharacterFromString(s);
        Console.WriteLine(c);
    }

    [TestMethod]
    public void TestIntArrayPermutation()
    {
        //int[] a = { 1, 2, 3 };
        //Permutations.Permute(a);
        Permutations.Combine(4, 2);
    }

    [TestMethod]
    public void Test()
    {
        Solution s = new Solution();
        
        ListNode l1 = new ListNode(9);

        ListNode l2 = new ListNode(1);
        ListNode a = new ListNode(9);
        ListNode b = new ListNode(9);
        ListNode c = new ListNode(9);
        ListNode d = new ListNode(9);
        ListNode e = new ListNode(9);
        ListNode f = new ListNode(9);
        ListNode g = new ListNode(9);
        ListNode h= new ListNode(9);
        ListNode i = new ListNode(9);


        l2.next = a;
        a.next = b;
        b.next = c;
        c.next = d;
        d.next = e;
        e.next = f;
        f.next = g;
        g.next = h;
        h.next = i;

        s.AddTwoNumbers(l1,l2);

    }
    [TestMethod]
    public void TestReverseListNode()
    {
        Solution s = new Solution();

        ListNode l1 = new ListNode(1);
        l1.next = new ListNode(2);
        l1.next.next = new ListNode(3);
        l1.next.next.next = new ListNode(4);
        l1.next.next.next.next = new ListNode(5);
        l1.next.next.next.next.next = new ListNode(6);


        s.ReverseEveryKNode(l1, 3);


    }

    [TestMethod]
    public void TestAmazonInterviewQuestion()
    {
        AmazonInterview amazon = new AmazonInterview();
        amazon.NewUserLogin("John");
        amazon.NewUserLogin("Jeff");
        amazon.NewUserLogin("John");
        string result = amazon.GetOldestOneTimeLoginUser();
      }

    [TestMethod]
    public void TestStringReverse()
    {
        RomanToInteger test = new RomanToInteger();
        test.ReverseWords("the sky is   blue");
    }

    [TestMethod]
    public void TestIntegertoRoman()
    {
        IntegerToRoman integerToRoman = new IntegerToRoman();
        integerToRoman.ConvertIntegerToRoman(3333);
    }
}