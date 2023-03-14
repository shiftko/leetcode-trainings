using Problems.Shared;

namespace Problems;

public static class NAryTreePreorderTraversal
{
    public static IList<int> Preorder(Node? root)
    {
        var list = new List<int>();

        if (root is not null)
        {
            list.Add(root.val);

            if (root.children is not null)
            {
                foreach (var child in root.children)
                {
                    list.AddRange(Preorder(child));
                }
            }
        }

        return list;
    }
}