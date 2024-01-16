using Ds.Collections;
using Entities;

namespace Tests;

public class LinkedListTest
{
  public static void testAddLinkedList(){
    ListaLigada listaLigada = new ListaLigada();

    Console.WriteLine(listaLigada.ToString());
    listaLigada.AdicionaNoComeco("Joao");
    Console.WriteLine(listaLigada.ToString());
    listaLigada.AdicionaNoComeco("Jose");
    Console.WriteLine(listaLigada.ToString());
    listaLigada.AdicionaNoComeco("Danilo");
    Console.WriteLine(listaLigada.ToString());

    listaLigada.Adiciona("Pedro");
    Console.WriteLine(listaLigada.ToString());

    listaLigada.Adiciona(2, "Gabriel");
    Console.WriteLine(listaLigada.ToString());

    Object x = listaLigada.Pega(2);
    Console.WriteLine(x);

    Console.WriteLine(listaLigada.Tamanho().ToString());

    listaLigada.RemoveDoComeco();
    Console.WriteLine(listaLigada.ToString());
    Console.WriteLine(listaLigada.Tamanho().ToString());

    listaLigada.RemoveDoFim();
    Console.WriteLine(listaLigada.ToString());
    Console.WriteLine(listaLigada.Tamanho().ToString());

    listaLigada.Adiciona("Jose");
    listaLigada.Adiciona("Ana");
    Console.WriteLine(listaLigada.ToString());

    listaLigada.Remove(2);
    Console.WriteLine(listaLigada.ToString());

    Console.WriteLine(listaLigada.Contem("Jose").ToString());
    Console.WriteLine(listaLigada.Contem("Joao").ToString());
  }
}