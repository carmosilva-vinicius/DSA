using System.Text;

namespace CSharpDSImplementation.DataStructures;

public class DsArray<T>
{
    private T[] _array = new T[100];
    public int Length { get; private set; }

    public void Add(T item)
    {
        checkCapacity();
        _array[Length] = item;
        Length++;
    }

    public void Add(T item, int position)
    {
        checkCapacity();
        if(!isPositionValid(position))
            throw new ArgumentOutOfRangeException(nameof(position));
        for(int i = Length - 1; i >= position; i--)
        {
            _array[i + 1] = _array[i];
        }
        _array[position] = item;
        Length++;
    }

    public T Get(int position)
    {
        if(!isPositionOccupied(position))
            throw new ArgumentOutOfRangeException(nameof(position));
        return _array[position];
    }

    public void Remove(int position)
    {
        if(!isPositionOccupied(position))
            throw new ArgumentOutOfRangeException(nameof(position));
        for(int i = position; i < Length; i++)
        {
            _array[i] = _array[i + 1];
        }
        Length--;
    }

    public bool Contains(T item)
    {
        for(int i = 0; i < Length; i++)
        {
            if(_array[i].Equals(item))
                return true;
        }
        return false;
    }

    public string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("[");
        for(int i = 0; i < Length; i++)
        {
            sb.Append(_array[i]);
            if(i != Length - 1)
                sb.Append(", ");
        }
        sb.Append("]");
        return sb.ToString();
    }

    private bool isPositionValid(int position) =>
        position >= 0 && position < Length;

    private bool isPositionOccupied(int position) =>
        _array[position] != null && isPositionValid(position);
    private void checkCapacity()
    {
        if(Length == _array.Length)
        {
            var newArray = new T[Length * 2];
            for(int i = 0; i < Length; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }
    }
}
