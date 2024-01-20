namespace CSharpDSImplementation.DataStructures;

public class ListNode<T>
{
    public T Data { get; set; }
    public ListNode<T>? Next { get; set; }
    public ListNode<T>? Previous { get; set; }

    public ListNode(T data)
    {
        Data = data;
        Next = null;
    }

    public ListNode(T data, ListNode<T> next)
    {
        Data = data;
        Next = next;
    }
}
