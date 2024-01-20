using CSharpDSImplementation.DataStructures;
using Xunit.Abstractions;

namespace DSTests;

public class QueueTest
{
   private DsQueue<int> _intQueue;
   private DsQueue<string> _stringQueue;
   private ITestOutputHelper _outputHelper;

   public QueueTest(ITestOutputHelper outputHelper)
   {
       _outputHelper = outputHelper;
       _intQueue = new DsQueue<int>();
        _stringQueue = new DsQueue<string>();

        _intQueue.Add(1);
        _intQueue.Add(2);
        _intQueue.Add(3);

        _stringQueue.Add("a");
        _stringQueue.Add("b");
        _stringQueue.Add("c");
   }

  [Fact]
  public void TestAdding_IntQueue()
  {
      _intQueue.Add(4);
      var length = _intQueue.Length;
      int? addedItem = null;

      for (int i = 0; i < length; i++)
      {
          addedItem = _intQueue.Remove();
      }

      Assert.Equal(4, length);
      Assert.Equal(4, addedItem);
  }

  [Fact]
  public void TestRemoving_IntQueue()
    {
        var removedItem = _intQueue.Remove();
        var length = _intQueue.Length;

        Assert.Equal(1, removedItem);
        Assert.Equal(2, length);
    }

    [Fact]
    public void TestAdding_StringQueue()
    {
        _stringQueue.Add("d");
        var length = _stringQueue.Length;
        string? addedItem = null;

        for (int i = 0; i < length; i++)
        {
            addedItem = _stringQueue.Remove();
        }

        Assert.Equal(4, length);
        Assert.Equal("d", addedItem);
    }

    [Fact]
    public void TestRemoving_StringQueue()
    {
        var removedItem = _stringQueue.Remove();
        var length = _stringQueue.Length;

        Assert.Equal("a", removedItem);
        Assert.Equal(2, length);
    }

    [Fact]
    public void TestIsEmpty_IntQueue()
    {
        var emptyQueue = new DsQueue<int>();
        var nonEmptyQueue = new DsQueue<int>();
        nonEmptyQueue.Add(1);

        Assert.True(emptyQueue.IsEmpty());
        Assert.False(nonEmptyQueue.IsEmpty());
    }

    [Fact]
    public void TestIsEmpty_StringQueue()
    {
        var emptyQueue = new DsQueue<string>();
        var nonEmptyQueue = new DsQueue<string>();
        nonEmptyQueue.Add("a");

        Assert.True(emptyQueue.IsEmpty());
        Assert.False(nonEmptyQueue.IsEmpty());
    }

    [Fact]
    public void TestToString_IntQueue()
    {
        var queue = new DsQueue<int>();
        queue.Add(1);
        queue.Add(2);
        queue.Add(3);
        _outputHelper.WriteLine(queue.ToString());
        _outputHelper.WriteLine(" ===============\\n-> 3 -> 2 -> 1 ->\\n ===============");
        Assert.Equal(" ===============\n-> 3 -> 2 -> 1 ->\n ===============", queue.ToString());
    }

    [Fact]
    public void TestToString_StringQueue()
    {
        var queue = new DsQueue<string>();
        queue.Add("a");
        queue.Add("b");
        queue.Add("c");

        Assert.Equal(" ===============\n-> c -> b -> a ->\n ===============", queue.ToString());
    }

    [Fact]
    public void TestToString_EmptyQueue()
    {
        var queue = new DsQueue<string>();

        Assert.Equal(" \n->  ->\n ", queue.ToString());
    }

    [Fact]
    public void TestLength_IntQueue()
    {
        var queue = new DsQueue<int>();
        queue.Add(1);
        queue.Add(2);
        queue.Add(3);

        Assert.Equal(3, queue.Length);
    }

}
