using CSharpDSImplementation.DataStructures;

DsArray<int> array = new DsArray<int>();

array.Add(1);
array.Add(2);
array.Add(3);
Console.WriteLine(array.ToString());
Console.WriteLine(array.Get(1));

array.Remove(1);
Console.WriteLine(array.ToString());

array.Add(2, 1);
Console.WriteLine(array.ToString());
Console.WriteLine(array.Contains(2));
Console.WriteLine(array.Contains(4));
Console.WriteLine(array.Length);
