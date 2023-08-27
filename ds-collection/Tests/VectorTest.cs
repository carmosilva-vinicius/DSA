using Ds.Collections;
using Entities;

namespace Tests;
public class VectorTest
{
  public static void testAddVector(){
    Aluno a1 = new Aluno("Joao");
    Aluno a2 = new Aluno("Jose");

    Vector vector = new Vector();
    vector.Add(a1);
    vector.Add(a2);

    Console.WriteLine(vector);
  }
}
