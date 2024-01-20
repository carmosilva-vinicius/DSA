using System.Text;

namespace CSharpDSImplementation.DataStructures;

public class DsQueue<T>
{
    private readonly DsLinkedList<T> _list = new DsLinkedList<T>();
    public int Length => _list.Length;

    public void Add(T item) => _list.Add(item);

    public T Remove()
    {
        var item = _list.Get(0);
        _list.Remove(0);
        return (T)item;
    }

    public bool IsEmpty() => _list.Length == 0;

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("[");
        for (int i = 0; i < _list.Length; i++)
        {
            sb.Append(_list.Get(i));
            if (i != _list.Length - 1)
                sb.Append(", ");
        }
        sb.Append("]");
        return sb.ToString();
    }
}
