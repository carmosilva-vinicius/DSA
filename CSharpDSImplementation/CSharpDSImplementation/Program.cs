using CSharpDSImplementation.DataStructures;

PresentArray();
PresentLinkedList();
PresentQueue();
PresentStack();
PresentBinarySearchTree();

return;

void PresentArray()
{
    Console.WriteLine("**********************************");
    Console.WriteLine("*             Array              *");
    Console.WriteLine("**********************************");

    DsArray<object> array = new();
    array.Add(1);
    array.Add(2);
    array.Add(3);
    array.Add(4);

    Console.WriteLine("\nGet at index 2: " + array.Get(2));
    Console.WriteLine("\nContains 3: " + array.Contains(3));
    Console.WriteLine("Contains 5: " + array.Contains(5));

    Console.WriteLine("\nArray:");
    Console.WriteLine(array.ToString());

    Console.WriteLine("\nAdd 5:");
    array.Add(5);
    Console.WriteLine(array.ToString());

    Console.WriteLine("\nInsert 6 at index 2:");
    array.Add(6, 2);
    Console.WriteLine(array.ToString());

    Console.WriteLine("\nRemove 6:");
    array.Remove(2);
    Console.WriteLine(array.ToString());
}

void PresentLinkedList()
{
    Console.WriteLine("\n**********************************");
    Console.WriteLine("*           Linked List          *");
    Console.WriteLine("**********************************");

    DsLinkedList<object> list = new();
    list.Add(1);
    list.Add(2);
    list.Add(3);
    list.Add(4);

    Console.WriteLine("\nGet at index 2: " + list.Get(2));
    Console.WriteLine("\nContains 3: " + list.Contains(3));
    Console.WriteLine("Contains 5: " + list.Contains(5));

    Console.WriteLine("\nLinked List:");
    Console.WriteLine(list.ToString());

    Console.WriteLine("\nAdd 5 e insert 6 at index 2:");
    list.Add(5);
    list.Add(6, 2);
    Console.WriteLine(list.ToString());
    Console.WriteLine("\nLength: " + list.Length);

    Console.WriteLine("\nRemove 6:");
    list.Remove(2);
    Console.WriteLine(list.ToString());
    Console.WriteLine("\nLength: " + list.Length);

    Console.WriteLine("\nRemove First:");
    list.RemoveFirst();
    Console.WriteLine(list.ToString());

    Console.WriteLine("\nRemove Last:");
    list.RemoveLast();
    Console.WriteLine(list.ToString());
}

void PresentQueue()
{
    Console.WriteLine("\n**********************************");
    Console.WriteLine("*             Queue              *");
    Console.WriteLine("**********************************");

    DsQueue<object> queue = new();
    Console.WriteLine("\nLength: " + queue.Length);
    Console.WriteLine($"Is empty: {queue.IsEmpty()}");
    Console.WriteLine(queue.ToString());
    queue.Add(1);
    queue.Add(2);
    queue.Add(3);
    queue.Add(4);

    Console.WriteLine("Length: " + queue.Length);
    Console.WriteLine($"Is empty: {queue.IsEmpty()}");
    Console.WriteLine(queue.ToString());

    Console.WriteLine($"\nRemoving: {queue.Remove()}");
    Console.WriteLine("Length: " + queue.Length);
    Console.WriteLine(queue.ToString());
}

void PresentStack()
{
    Console.WriteLine("\n**********************************");
    Console.WriteLine("*             Stack              *");
    Console.WriteLine("**********************************");

    DsStack<int> stack = new();
    Console.WriteLine("\nLength: " + stack.Length);
    Console.WriteLine(stack.ToString());

    stack.Insert(1);
    stack.Insert(2);
    stack.Insert(3);
    stack.Insert(4);
    Console.WriteLine("\nLength: " + stack.Length);
    Console.WriteLine(stack.ToString());

    Console.WriteLine($"\nRemoving: {stack.Remove()}");
    Console.WriteLine("Length: " + stack.Length);
    Console.WriteLine($"Removing: {stack.Remove()}");
    Console.WriteLine("Length: " + stack.Length);
    Console.WriteLine($"Adding 5...");
    stack.Insert(5);
    Console.WriteLine("Length: " + stack.Length);
    Console.WriteLine(stack.ToString());
}

void PresentBinarySearchTree()
{
    Console.WriteLine("\n**********************************");
    Console.WriteLine("*       Binary Search Tree       *");
    Console.WriteLine("**********************************");

    DsBinarySearchTree<int> bst = new();
    bst.Add(5);
    bst.Add(3);
    bst.Add(7);
    bst.Add(2);
    bst.Add(4);
    bst.Add(6);
    bst.Add(8);

    Console.WriteLine($"\nDepth: {bst.Depth()}");

    Console.WriteLine("\nIn Order Traversal:");
    bst.TraverseInOrder(bst.Root);
    Console.WriteLine("\nPre Order Traversal:");
    bst.TraversePreOrder(bst.Root);
    Console.WriteLine("\nPost Order Traversal:");
    bst.TraversePostOrder(bst.Root);

    Console.WriteLine("\n\nPrint Tree:");
    bst.PrintTree();

    Console.WriteLine("\n\nFind 5: " + bst.Find(5));
    Console.WriteLine("Find 10: " + bst.Find(10));

    bst.Remove(5);
    Console.WriteLine("\n\nRemove 5:");

    Console.WriteLine("\nIn Order Traversal:");
    bst.TraverseInOrder(bst.Root);
    Console.WriteLine("\nPre Order Traversal:");
    bst.TraversePreOrder(bst.Root);
    Console.WriteLine("\nPost Order Traversal:");
    bst.TraversePostOrder(bst.Root);

    Console.WriteLine("\n\nPrint Tree:");
    bst.PrintTree();
}
