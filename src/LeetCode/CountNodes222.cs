using LeetCode.Common;

namespace LeetCode;
public class CountNodes222
{
    public int CountNodes(TreeNode root)
    {
        var h = 0;
        if (root == null) return 0;
        return 1 + CountNodes(root.left) + CountNodes(root.right);
    }
}
