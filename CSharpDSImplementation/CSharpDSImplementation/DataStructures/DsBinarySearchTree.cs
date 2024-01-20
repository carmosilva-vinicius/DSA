namespace CSharpDSImplementation.DataStructures;

public class DsBinarySearchTree<T> where T : IComparable<T>
{
    public TreeNode<T>? Root { get; set; }
    public TreeNode<T> Find(T data) => Find(data, this.Root);
    public void Remove(T data) => Remove(data, this.Root);
    public int Depth() => GetTreeDepth(this.Root);
    public void PrintTree() => PrintTree(Root);

    public bool Add(T data)
    {
        TreeNode<T> before = null, after = this.Root;
        while (after != null)
        {
            before = after;
            int compare = data.CompareTo(after.Data);
            if (compare < 0)
            {
                after = after.Left;
            }
            else if (compare > 0)
            {
                after = after.Right;
            }
            else
            {
                return false;
            }
        }
        TreeNode<T> newNode = new TreeNode<T>();
        newNode.Data = data;
        if (this.Root == null)
        {
            this.Root = newNode;
        }
        else
        {
            int compare = data.CompareTo(before!.Data);
            if (compare < 0)
            {
                before!.Left = newNode;
            }
            else
            {
                before!.Right = newNode;
            }
        }
        return true;
    }

    private TreeNode<T> Find(T data, TreeNode<T>? parent)
    {
        if (parent != null)
        {
            int compare = data.CompareTo(parent.Data);
            if (compare == 0)
            {
                return parent;
            }
            if (compare < 0)
            {
                return Find(data, parent.Left);
            }
            else
            {
                return Find(data, parent.Right);
            }
        }
        return null!;
    }

    private TreeNode<T>? Remove(T data, TreeNode<T>? parent)
    {
        if (parent == null)
            return parent;
        int compare = data.CompareTo(parent.Data);
        if (compare < 0)
        {
            parent.Left = Remove(data, parent.Left);
        }
        else if (compare > 0)
        {
            parent.Right = Remove(data, parent.Right);
        }
        else
        {
            if (parent.Left == null)
            {
                return parent.Right;
            }
            else if (parent.Right == null)
            {
                return parent.Left;
            }
            else
            {
                parent.Data = MinValue(parent.Right);
                parent.Right = Remove(parent.Data, parent.Right);
            }
        }
        return parent;
    }

    private T MinValue(TreeNode<T> node)
    {
        T minv = node.Data;
        while (node.Left != null)
        {
            minv = node.Left.Data;
            node = node.Left;
        }
        return minv;
    }

    private int GetTreeDepth(TreeNode<T>? node)
    {
        if (node == null)
            return 0;
        else
        {
            return Math.Max(
                GetTreeDepth(node.Left),
                GetTreeDepth(node.Right)) + 1;
        }
    }

    private void PrintTree(TreeNode<T>? node, string indent = "", bool last = true)
    {
        if (node != null)
        {
            Console.Write(indent);
            if (last)
            {
                Console.Write("R----");
                indent += "     ";
            }
            else
            {
                Console.Write("L----");
                indent += "|    ";
            }
            Console.WriteLine(node.Data);
            PrintTree(node.Left, indent, false);
            PrintTree(node.Right, indent, true);
        }
    }

    public void TraversePreOrder(TreeNode<T>? node)
    {
        if (node != null)
        {
            Console.Write(node.Data + " ");
            TraversePreOrder(node.Left);
            TraversePreOrder(node.Right);
        }
    }

    public void TraverseInOrder(TreeNode<T>? node)
    {
        if (node != null)
        {
            TraverseInOrder(node.Left);
            Console.Write(node.Data + " ");
            TraverseInOrder(node.Right);
        }
    }

    public void TraversePostOrder(TreeNode<T>? node)
    {
        if (node != null)
        {
            TraversePostOrder(node.Left);
            TraversePostOrder(node.Right);
            Console.Write(node.Data + " ");
        }
    }
}
