using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Common;

namespace LeetCode.Tests;
public class CountNodes222Test
{
    [Fact]
    public void CountNodes()
    {
        TreeNode root = new TreeNode(1,
             new TreeNode(2,
                 new TreeNode(4),
                 new TreeNode(5)
           ),
            new TreeNode(3,
                new TreeNode(6),
                null
             )
        );
        var result = new CountNodes222().CountNodes(root);
        Assert.Equal(6, result);
    }
}
