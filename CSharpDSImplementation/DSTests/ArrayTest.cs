using CSharpDSImplementation.DataStructures;

namespace DSTests;

public class ArrayTest
{
    private DsArray<int> _intArray;
    private DsArray<string> _stringArray;

    public ArrayTest()
    {
        _intArray = new DsArray<int>();
        _stringArray = new DsArray<string>();

        _intArray.Add(1);
        _intArray.Add(2);
        _intArray.Add(3);

        _stringArray.Add("a");
        _stringArray.Add("b");
        _stringArray.Add("c");
    }

    [Fact]
    public void TestAdding_IntArray()
    {
        _intArray.Add(4);

        Assert.Equal(4, _intArray.Length);
    }

    [Fact]
    public void TestAdding_StringArray()
    {
        _stringArray.Add("d");

        Assert.Equal(4, _stringArray.Length);
    }

    [Fact]
    public void TestAddingAtPosition_IntArray()
    {
        _intArray.Add(4, 1);

        Assert.Equal(4, _intArray.Length);
        Assert.Equal(4, _intArray.Get(1));
    }

    [Fact]
    public void TestAddingAtPosition_StringArray()
    {
        _stringArray.Add("d", 1);

        Assert.Equal(4, _stringArray.Length);
        Assert.Equal("d", _stringArray.Get(1));
    }

    [Fact]
    public void TestGetting_IntArray()
    {
        Assert.Equal(2, _intArray.Get(1));
    }

    [Fact]
    public void TestGetting_StringArray()
    {
        Assert.Equal("b", _stringArray.Get(1));
    }

    [Fact]
    public void TestRemoving_IntArray()
    {
        _intArray.Remove(1);

        Assert.Equal(2, _intArray.Length);
        Assert.Equal(3, _intArray.Get(1));
    }

    [Fact]
    public void TestRemoving_StringArray()
    {
        _stringArray.Remove(1);

        Assert.Equal(2, _stringArray.Length);
        Assert.Equal("c", _stringArray.Get(1));
    }

    [Fact]
    public void TestContains_IntArray()
    {
        Assert.True(_intArray.Contains(2));
        Assert.False(_intArray.Contains(4));
    }

    [Fact]
    public void TestContains_StringArray()
    {
        Assert.True(_stringArray.Contains("b"));
        Assert.False(_stringArray.Contains("d"));
    }

    [Fact]
    public void TestToString_IntArray()
    {
        Assert.Equal("[1, 2, 3]", _intArray.ToString());
    }

    [Fact]
    public void TestToString_StringArray()
    {
        Assert.Equal("[a, b, c]", _stringArray.ToString());
    }

    [Fact]
    public void TestToString_EmptyArray()
    {
        DsArray<object> emptyArray = new DsArray<object>();
        Assert.Equal("[]", emptyArray.ToString());
    }

    [Fact]
    public void TestAddingAtInvalidPosition_IntArray()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => _intArray.Add(4, 4));
    }

    [Fact]
    public void TestAddingAtInvalidPosition_StringArray()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => _stringArray.Add("d", 4));
    }

    [Fact]
    public void TestGettingAtInvalidPosition_IntArray()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => _intArray.Get(3));
    }

    [Fact]
    public void TestGettingAtInvalidPosition_StringArray()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => _stringArray.Get(3));
    }

    [Fact]
    public void TestRemovingAtInvalidPosition_IntArray()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => _intArray.Remove(3));
    }

    [Fact]
    public void TestRemovingAtInvalidPosition_StringArray()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => _stringArray.Remove(3));
    }

}
