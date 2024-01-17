namespace CSharpDSImplementation.DataStructures;

public class Node
{
    public Object Data { get; set; }
    public Node? Next { get; set; }
    public Node? Previous { get; set; }

    public Node(Object data)
    {
        Data = data;
        Next = null;
    }

    public Node(Object data, Node next)
    {
        Data = data;
        Next = next;
    }
}
