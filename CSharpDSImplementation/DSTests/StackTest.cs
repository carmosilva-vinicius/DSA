using CSharpDSImplementation.DataStructures;

namespace DSTests;

public class StackTest
{
    private DsStack<int> _intStack;
    private DsStack<string> _stringStack;

    public StackTest()
    {
        _intStack = new DsStack<int>();
        _stringStack = new DsStack<string>();

        _intStack.Insert(1);
        _intStack.Insert(2);
        _intStack.Insert(3);

        _stringStack.Insert("a");
        _stringStack.Insert("b");
        _stringStack.Insert("c");
    }

    [Fact]
    public void TestInserting_IntStack()
    {
        _intStack.Insert(4);
        var length = _intStack.Length;
        var addedItem = _intStack.Remove();

        Assert.Equal(4, length);
        Assert.Equal(4, addedItem);
    }

    [Fact]
    public void TestRemoving_IntStack()
    {
        var removedItem = _intStack.Remove();
        var length = _intStack.Length;

        Assert.Equal(3, removedItem);
        Assert.Equal(2, length);
    }

    [Fact]
    public void TestInserting_StringStack()
    {
        _stringStack.Insert("d");
        var length = _stringStack.Length;
        var addedItem = _stringStack.Remove();

        Assert.Equal(4, length);
        Assert.Equal("d", addedItem);
    }

    [Fact]
    public void TestRemoving_StringStack()
    {
        var removedItem = _stringStack.Remove();
        var length = _stringStack.Length;

        Assert.Equal("c", removedItem);
        Assert.Equal(2, length);
    }

    [Fact]
    public void TestToString_IntStack()
    {
        var stackString = _intStack.ToString();
        Assert.Equal("|^|\n|3|\n|2|\n|1|\n|_|", stackString);
    }

    [Fact]
    public void TestToString_StringStack()
    {
        var stackString = _stringStack.ToString();
        Assert.Equal("|^|\n|c|\n|b|\n|a|\n|_|", stackString);
    }

    [Fact]
    public void TestToString_EmptyStack()
    {
        var emptyStack = new DsStack<object>();

        Assert.Equal("|^|\n|_|", emptyStack.ToString());
    }
}
