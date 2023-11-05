using System.Text;

namespace Ds.Collections;

public class Pilha
{
  private readonly LinkedList<string> nomes = new LinkedList<string>();

  public void Insere(string nome)
  {
    nomes.AddLast(nome);
  }

  public string Remove()
  {
    var nome = nomes.Last();
    nomes.RemoveLast();
    return nome;
  }

  public bool Vazia()
  {
    return nomes.Count() == 0;
  }

  public override string ToString()
  {
    StringBuilder sb = new StringBuilder("[");
    foreach (var item in nomes)
    {
        sb.Append(item);
        sb.Append(",");
    }
    sb.Append("]");
    return sb.ToString();
  }
}