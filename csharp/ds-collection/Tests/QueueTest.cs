using Ds.Collections;

namespace Tests;
public class QueueTest
{
  public static void testQueue()
  {
    Fila fila = new Fila();

    fila.Adiciona("Mauricio");
    fila.Adiciona("Guilherme");

    Console.WriteLine(fila);

    string x1 = fila.Remove();
    Console.WriteLine(x1);
    Console.WriteLine(fila);

    Console.WriteLine(fila.Vazia());
    string x2 = fila.Remove();
    Console.WriteLine(x2);
    Console.WriteLine(fila.Vazia());
    Console.WriteLine(fila);
  }
}