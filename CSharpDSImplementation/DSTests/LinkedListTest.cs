using CSharpDSImplementation.DataStructures;

namespace DSTests;

public class LinkedListTest
{
    private DsLinkedList<int> _list;

    public LinkedListTest()
    {
        _list = new DsLinkedList<int>();

        _list.Add(1);
        _list.Add(2);
        _list.Add(3);
    }


    [Fact]
    public void TestAdding()
    {
        _list.Add(4);

        Assert.Equal(4, _list.Length);
        Assert.Equal(4, _list.Get(3));
    }

    [Fact]
    public void TestPrepending()
    {
        _list.Prepend(0);

        Assert.Equal(4, _list.Length);
        Assert.Equal(0, _list.Get(0));
    }

    [Fact]
    public void TestAddingAtPosition()
    {
        _list.Add(4, 1);

        Assert.Equal(4, _list.Length);
        Assert.Equal(4, _list.Get(1));
    }

    [Fact]
    public void TestGetting()
    {
        Assert.Equal(1, _list.Get(0));
        Assert.Equal(2, _list.Get(1));
        Assert.Equal(3, _list.Get(2));
    }

    [Fact]
    public void TestRemoving()
    {
        _list.Remove(1);

        Assert.Equal(2, _list.Length);
        Assert.Equal(1, _list.Get(0));
        Assert.Equal(3, _list.Get(1));
    }

    [Fact]
    public void TestRemovingFirst()
    {
        _list.RemoveFirst();

        Assert.Equal(2, _list.Length);
        Assert.Equal(2, _list.Get(0));
        Assert.Equal(3, _list.Get(1));
    }

    [Fact]
    public void TestRemovingLast()
    {
        _list.RemoveLast();

        Assert.Equal(2, _list.Length);
        Assert.Equal(1, _list.Get(0));
        Assert.Equal(2, _list.Get(1));
    }

    [Fact]
    public void TestContains()
    {
        Assert.True(_list.Contains(1));
        Assert.True(_list.Contains(2));
        Assert.True(_list.Contains(3));
        Assert.False(_list.Contains(4));
    }

    [Fact]
    public void TestToString()
    {
        var emptyList = new DsLinkedList<int>();
        Assert.Equal("[1, 2, 3]", _list.ToString());
        Assert.Equal("[]", emptyList.ToString());
    }

    //test exceptions

    [Fact]
    public void TestGetting_InvalidIndex()
    {
        Assert.Throws<ArgumentException>(() => _list.Get(3));
    }

    [Fact]
    public void TestRemovingFirst_EmptyList()
    {
        var emptyList = new DsLinkedList<int>();
        Assert.Throws<ArgumentException>(() => emptyList.RemoveFirst());
    }

    [Fact]
    public void TestRemovingLast_EmptyList()
    {
        var emptyList = new DsLinkedList<int>();
        Assert.Throws<ArgumentException>(() => emptyList.RemoveLast());
    }
}
