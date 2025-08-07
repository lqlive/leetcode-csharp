using LeetCode.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;

public class InorderTraversal94
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        var result= new List<int>();
        Inorder(root, result);
        return result;
    }

    public void Inorder(TreeNode root,List<int> result)
    {
        if (root is null)
        {
            return;
        }
        Inorder(root.left, result);
        result.Add(root.val);
        Inorder(root.right, result);
    }
}