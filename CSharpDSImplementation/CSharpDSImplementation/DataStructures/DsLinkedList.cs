using System.Text;

namespace CSharpDSImplementation.DataStructures;

public class DsLinkedList<T>
{
    private Node<T>? _first = null;
    private Node<T>? _last = null;
    public int Length { get; set; } = 0;

    public void Prepend(T data)
    {
        if(Length == 0)
        {
            _first = new Node<T>(data);
            _last = _first;
        }
        else
        {
            var newNode = new Node<T>(data, _first);
            _first.Previous = newNode;
            _first = newNode;
        }
        Length++;
    }

    public void Add(T data)
    {
        if(Length == 0)
        {
            _first = new Node<T>(data);
            _last = _first;
        }
        else
        {
            var newNode = new Node<T>(data);
            _last.Next = newNode;
            newNode.Previous = _last;
            _last = newNode;
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
            var previousNode = GetNode(index - 1);
            var nextNode = previousNode.Next!;
            var newNode = new Node<T>(data, previousNode.Next) { Previous = previousNode };
            previousNode.Next = newNode;
            nextNode.Previous = newNode;
            Length++;
        }
    }

    public T Get(int index) => GetNode(index).Data;

    private Node<T> GetNode(int index)
    {
        if (!OccupiedPosition(index))
            throw new ArgumentException("Index out of range");
        var currentNode = _first!;
        for (var i = 0; i < index; i++)
        {
            currentNode = currentNode.Next!;
        }
        return currentNode;
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
            var previousNode = GetNode(index - 1);
            var currentNode = previousNode.Next!;
            var nextNode = currentNode.Next!;
            previousNode.Next = nextNode;
            nextNode!.Previous = previousNode;
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
            Node<T> penultimateNode = _last!.Previous!;
            penultimateNode.Next = null;
            _last = penultimateNode;
            Length--;
        }
    }

    public bool Contains(T data)
    {
        var currentNode = _first;
        while(currentNode != null)
        {
            if (currentNode.Data.Equals(data))
                return true;
            currentNode = currentNode.Next;
        }
        return false;
    }

    public override string ToString()
    {
        if (Length == 0)
            return "[]";
        var sb = new StringBuilder();
        sb.Append("[");
        var currentNode = _first;
        while(currentNode != null)
        {
            sb.Append(currentNode.Data);
            if(currentNode.Next != null)
                sb.Append(", ");
            currentNode = currentNode.Next;
        }
        sb.Append("]");
        return sb.ToString();
    }
}
