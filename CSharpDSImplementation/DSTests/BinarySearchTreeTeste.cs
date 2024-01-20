using CSharpDSImplementation.DataStructures;

namespace DSTests;

public class BinarySearchTreeTeste
{
    private DsBinarySearchTree<int> _tree;

    public BinarySearchTreeTeste()
    {
        _tree = new DsBinarySearchTree<int>();

        _tree.Add(5);
        _tree.Add(3);
        _tree.Add(7);
        _tree.Add(2);
        _tree.Add(4);
        _tree.Add(6);
        _tree.Add(8);
    }

    [Fact]
    public void DepthTest()
    {
        Assert.Equal(3, _tree.Depth());
    }

    [Fact]
    public void FindTest()
    {
        Assert.Equal(5, _tree.Find(5).Data);
        Assert.Null(_tree.Find(10));
    }

    [Fact]
    public void RemoveTest()
    {
        _tree.Remove(5);
        Assert.Null(_tree.Find(5));
    }
}
