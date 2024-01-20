using System.Text;

namespace CSharpDSImplementation.DataStructures;

public class DsStack<T>
{
    private DsLinkedList<T> _list = new ();

    public int Length => _list.Length;
    public void Insert(T data) => _list.Add(data);

    public T Remove()
    {
        var item = _list.Get(_list.Length - 1);
        _list.RemoveLast();
        return item;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("|^|\n");
        for (int i = _list.Length; i > 0 ; i--)
        {
            sb.Append($"|{_list.Get(i - 1)}|\n");
        }
        sb.Append("|_|");
        return sb.ToString();
    }
}
