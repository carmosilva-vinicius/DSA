using CSharpDSImplementation.DataStructures;

DsArray<object> array = new();
DsLinkedList<object> list = new();
DsStack<object> stack = new();
DsQueue<object> queue = new();
DsBinarySearchTree<int> bst = new();

//array presentation
Console.WriteLine("**********************************");
Console.WriteLine("*             Array              *");
Console.WriteLine("**********************************");

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

//linked list presentation
Console.WriteLine("\n**********************************");
Console.WriteLine("*           Linked List          *");
Console.WriteLine("**********************************");

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

//tree presentation
Console.WriteLine("\n**********************************");
Console.WriteLine("*       Binary Search Tree       *");
Console.WriteLine("**********************************");

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
