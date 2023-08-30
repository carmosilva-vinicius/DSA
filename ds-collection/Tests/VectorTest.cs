using Ds.Collections;
using Entities;

namespace Tests;
public class VectorTest
{
  public static void testAddVector(){
    Aluno a1 = new Aluno("Joao");
    Aluno a2 = new Aluno("Jose");

    Vector vector = new Vector();

    Console.WriteLine(vector.Size());
    vector.Add(a1);
    Console.WriteLine(vector.Size());
    vector.Add(a2);
    Console.WriteLine(vector.Size());

    Console.WriteLine(vector);

    Console.WriteLine(vector.Contains(a1));

    Aluno a3 = new Aluno("Danilo");
    Console.WriteLine(vector.Contains(a3));

    Console.WriteLine(vector.Get(1));

    vector.Add(1, a3);
    Console.WriteLine(vector);

    vector.Remove(1);
    Console.WriteLine(vector);
  }
}
