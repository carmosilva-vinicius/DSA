using System.Text;

namespace CSharpDSImplementation.DataStructures;

public class DsLinkedList<T>
{
    private ListNode<T>? _first = null;
    private ListNode<T>? _last = null;
    public int Length { get; set; } = 0;

    public void Prepend(T data)
    {
        if(Length == 0)
        {
            _first = new ListNode<T>(data);
            _last = _first;
        }
        else
        {
            var newListNode = new ListNode<T>(data, _first);
            _first.Previous = newListNode;
            _first = newListNode;
        }
        Length++;
    }

    public void Add(T data)
    {
        if(Length == 0)
        {
            _first = new ListNode<T>(data);
            _last = _first;
        }
        else
        {
            var newListNode = new ListNode<T>(data);
            _last.Next = newListNode;
            newListNode.Previous = _last;
            _last = newListNode;
        }
        Length++;
    }

    public void Add(T data, int index)
    {
        if (index == 0)
            Prepend(data);
        else if (index == Length)
            Add(data);
        else
        {
            var previousListNode = GetListNode(index - 1);
            var nextListNode = previousListNode.Next!;
            var newListNode = new ListNode<T>(data, previousListNode.Next) { Previous = previousListNode };
            previousListNode.Next = newListNode;
            nextListNode.Previous = newListNode;
            Length++;
        }
    }

    public T Get(int index) => GetListNode(index).Data;

    private ListNode<T> GetListNode(int index)
    {
        if (!OccupiedPosition(index))
            throw new ArgumentException("Index out of range");
        var currentListNode = _first!;
        for (var i = 0; i < index; i++)
        {
            currentListNode = currentListNode.Next!;
        }
        return currentListNode;
    }

    private bool OccupiedPosition(int index) =>
        index >= 0 && index < Length;

    public void Remove(int index)
    {
        if(index == 0)
            RemoveFirst();
        else if (index == Length - 1)
            RemoveLast();
        else
        {
            var previousListNode = GetListNode(index - 1);
            var currentListNode = previousListNode.Next!;
            var nextListNode = currentListNode.Next!;
            previousListNode.Next = nextListNode;
            nextListNode!.Previous = previousListNode;
            Length--;
        }
    }

    public void RemoveFirst()
    {
        if (Length == 0)
            throw new ArgumentException("Empty list");
        _first = _first!.Next;
        Length--;

        if (Length == 0)
            _last = null;
    }

    public void RemoveLast()
    {
        if (Length == 0)
            throw new ArgumentException("Empty list");
        if(Length == 1)
            RemoveFirst();
        else
        {
            ListNode<T> penultimateListNode = _last!.Previous!;
            penultimateListNode.Next = null;
            _last = penultimateListNode;
            Length--;
        }
    }

    public bool Contains(T data)
    {
        var currentListNode = _first;
        while(currentListNode != null)
        {
            if (currentListNode.Data.Equals(data))
                return true;
            currentListNode = currentListNode.Next;
        }
        return false;
    }


    public override string ToString()
    {
        if (Length == 0)
            return "[]";
        var sb = new StringBuilder();
        var currentListNode = _first;
        while(currentListNode != null)
        {
            sb.Append($"[{currentListNode.Data}]<->");
            currentListNode = currentListNode.Next;
        }
        sb.Append("[]");
        return sb.ToString();
    }
}
