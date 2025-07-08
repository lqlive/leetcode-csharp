using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Common;

namespace LeetCode.Tests;
public class BinaryTreePaths257Test
{
    [Fact]
    public void TestBinaryTreePaths()
    {
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(3);
        root.left.right = new TreeNode(5);
        var result = new BinaryTreePaths257().BinaryTreePaths(root);

        Assert.Equal(["1->2->5", "1->3"], result);
    }
}
