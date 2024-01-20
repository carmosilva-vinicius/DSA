using CSharpDSImplementation.DataStructures;

namespace DSTests;

public class LinkedListTest
{
    private DsLinkedList<int> _intList;
    private DsLinkedList<string> _stringList;

    public LinkedListTest()
    {
        _intList = new DsLinkedList<int>();
        _stringList = new DsLinkedList<string>();

        _intList.Add(1);
        _intList.Add(2);
        _intList.Add(3);

        _stringList.Add("a");
        _stringList.Add("b");
        _stringList.Add("c");
    }


    [Fact]
    public void TestAdding_IntList()
    {
        _intList.Add(4);

        Assert.Equal(4, _intList.Length);
        Assert.Equal(4, _intList.Get(3));
    }

    [Fact]
    public void TestPrepending_IntList()
    {
        _intList.Prepend(0);

        Assert.Equal(4, _intList.Length);
        Assert.Equal(0, _intList.Get(0));
    }

    [Fact]
    public void TestAddingAtPosition_IntList()
    {
        _intList.Add(4, 1);

        Assert.Equal(4, _intList.Length);
        Assert.Equal(4, _intList.Get(1));
    }

    [Fact]
    public void TestGetting_IntList()
    {
        Assert.Equal(1, _intList.Get(0));
        Assert.Equal(2, _intList.Get(1));
        Assert.Equal(3, _intList.Get(2));
    }

    [Fact]
    public void TestRemoving_IntList()
    {
        _intList.Remove(1);

        Assert.Equal(2, _intList.Length);
        Assert.Equal(1, _intList.Get(0));
        Assert.Equal(3, _intList.Get(1));
    }

    [Fact]
    public void TestRemovingFirst_IntList()
    {
        _intList.RemoveFirst();

        Assert.Equal(2, _intList.Length);
        Assert.Equal(2, _intList.Get(0));
        Assert.Equal(3, _intList.Get(1));
    }

    [Fact]
    public void TestRemovingLast_IntList()
    {
        _intList.RemoveLast();

        Assert.Equal(2, _intList.Length);
        Assert.Equal(1, _intList.Get(0));
        Assert.Equal(2, _intList.Get(1));
    }

    [Fact]
    public void TestContains_IntList()
    {
        Assert.True(_intList.Contains(1));
        Assert.True(_intList.Contains(2));
        Assert.True(_intList.Contains(3));
        Assert.False(_intList.Contains(4));
    }

    [Fact]
    public void TestToString_IntList()
    {
        var emptyList = new DsLinkedList<int>();
        Assert.Equal("[1, 2, 3]", _intList.ToString());
        Assert.Equal("[]", emptyList.ToString());
    }

    [Fact]
    public void TestGetting_InvalidIndex_IntList()
    {
        Assert.Throws<ArgumentException>(() => _intList.Get(3));
    }

    [Fact]
    public void TestRemovingFirst_EmptyList_IntList()
    {
        var emptyList = new DsLinkedList<int>();
        Assert.Throws<ArgumentException>(() => emptyList.RemoveFirst());
    }

    [Fact]
    public void TestRemovingLast_EmptyList_IntList()
    {
        var emptyList = new DsLinkedList<int>();
        Assert.Throws<ArgumentException>(() => emptyList.RemoveLast());
    }

    [Fact]
    public void TestAdding_StringList()
    {
        _stringList.Add("d");

        Assert.Equal(4, _stringList.Length);
        Assert.Equal("d", _stringList.Get(3));
    }

    [Fact]
    public void TestPrepending_StringList()
    {
        _stringList.Prepend("z");

        Assert.Equal(4, _stringList.Length);
        Assert.Equal("z", _stringList.Get(0));
    }

    [Fact]
    public void TestAddingAtPosition_StringList()
    {
        _stringList.Add("d", 1);

        Assert.Equal(4, _stringList.Length);
        Assert.Equal("d", _stringList.Get(1));
    }

    [Fact]
    public void TestGetting_StringList()
    {
        Assert.Equal("a", _stringList.Get(0));
        Assert.Equal("b", _stringList.Get(1));
        Assert.Equal("c", _stringList.Get(2));
    }

    [Fact]
    public void TestRemoving_StringList()
    {
        _stringList.Remove(1);

        Assert.Equal(2, _stringList.Length);
        Assert.Equal("a", _stringList.Get(0));
        Assert.Equal("c", _stringList.Get(1));
    }

    [Fact]
    public void TestRemovingFirst_StringList()
    {
        _stringList.RemoveFirst();

        Assert.Equal(2, _stringList.Length);
        Assert.Equal("b", _stringList.Get(0));
        Assert.Equal("c", _stringList.Get(1));
    }

    [Fact]
    public void TestRemovingLast_StringList()
    {
        _stringList.RemoveLast();

        Assert.Equal(2, _stringList.Length);
        Assert.Equal("a", _stringList.Get(0));
        Assert.Equal("b", _stringList.Get(1));
    }

    [Fact]
    public void TestContains_StringList()
    {
        Assert.True(_stringList.Contains("a"));
        Assert.True(_stringList.Contains("b"));
        Assert.True(_stringList.Contains("c"));
        Assert.False(_stringList.Contains("d"));
    }

    [Fact]
    public void TestToString_StringList()
    {
        var emptyList = new DsLinkedList<string>();
        Assert.Equal("[a, b, c]", _stringList.ToString());
        Assert.Equal("[]", emptyList.ToString());
    }

    [Fact]
    public void TestGetting_InvalidIndex_StringList()
    {
        Assert.Throws<ArgumentException>(() => _stringList.Get(3));
    }

    [Fact]
    public void TestRemovingFirst_EmptyList_StringList()
    {
        var emptyList = new DsLinkedList<string>();
        Assert.Throws<ArgumentException>(() => emptyList.RemoveFirst());
    }

    [Fact]
    public void TestRemovingLast_EmptyList_StringList()
    {
        var emptyList = new DsLinkedList<string>();
        Assert.Throws<ArgumentException>(() => emptyList.RemoveLast());
    }
}
