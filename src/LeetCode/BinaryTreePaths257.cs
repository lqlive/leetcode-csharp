using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Common;

namespace LeetCode;
public class BinaryTreePaths257
{
    public IList<string> BinaryTreePaths(TreeNode root)
    {
        var paths  = new List<string>();
        EachNode(root, string.Empty, paths);
        return paths;
    }

    public void EachNode(TreeNode node, string path, List<string> paths)
    {
        if (node is null)
        {
            return;
        }
        var sb = new StringBuilder(path);
        sb.Append(node.val.ToString());
        if (node.left is null && node.right is null)
        {
            paths.Add(sb.ToString());
        }
        else
        {
            sb.Append("->");
            EachNode(node.left, sb.ToString(), paths);
            EachNode(node.right, sb.ToString(), paths);
        }
    }
}