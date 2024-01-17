using CSharpDSImplementation.DataStructures;

DsLinkedList list = new();

list.Add(1);
list.Add(2);
list.Add(3);
Console.WriteLine(list.ToString());

list.Prepend(0);
list.Add(4, 4);
Console.WriteLine(list.ToString());

Console.WriteLine(list.Get(2));

list.Remove(2);
Console.WriteLine(list.ToString());

list.RemoveFirst();
Console.WriteLine(list.ToString());

list.RemoveLast();
Console.WriteLine(list.ToString());

list.Add(2, 1);
Console.WriteLine(list.ToString());
