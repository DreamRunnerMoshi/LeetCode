using System;
using System.Collections.Generic;

namespace LeetCode.ProgramClient
{
    public class MaxHeightOfTree
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            var stack = new Stack<TreeNode>(); // keep track of nodes
            stack.Push(root);
            int maxHeight = 0;
            root.Depth = 1;
            while (stack.Count > 0)
            {
                var current = stack.Pop();
                int currentHeight = current.Depth;
                // check if right node of current is empty
                if (current.Right != null)
                {
                    current.Right.Depth = currentHeight + 1;
                    stack.Push(current.Right);
                }
                // check if left node of current is empty
                if (current.Left != null)
                {
                    current.Left.Depth = currentHeight + 1;
                    stack.Push(current.Left);
                }
                maxHeight = Math.Max(maxHeight, currentHeight);
            }
            return maxHeight;
        }
    }
}

public class TreeNode
{
    public TreeNode Left { get; set; }
    public TreeNode Right { get; set; }

    public int Value { get; }
    public int Depth { get; set; }
    public TreeNode(int value)
    {
        this.Value = value;
    }
}
