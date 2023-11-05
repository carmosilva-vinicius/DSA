using Ds.Collections;

namespace Tests;
public class StackTest
{
  public static void testStack()
  {
    Pilha pilha = new Pilha();

    Console.WriteLine(pilha.ToString());
    pilha.Insere("Joao");
    Console.WriteLine(pilha.ToString());
    pilha.Insere("Guilherme");
    Console.WriteLine(pilha.ToString());

    string r1 = pilha.Remove();
    Console.WriteLine(r1);
    string r2 = pilha.Remove();
    Console.WriteLine(r2);
    Console.WriteLine(pilha.ToString());
    
    Console.WriteLine(pilha.Vazia());
    pilha.Insere("Marcelo");
    Console.WriteLine(pilha.Vazia());
    Console.WriteLine(pilha.ToString());
  }
}
