using System.Text;

namespace Ds.Collections;

public class ListaLigada
{
  private Celula? primeira = null;
  private Celula? ultima = null;
  private int totalDeElementos = 0;

  public void AdicionaNoComeco(Object elemento) { 
    if(totalDeElementos == 0){
      Celula nova = new Celula(elemento);
      this.primeira = nova;
      this.ultima = nova;
    } else {
      Celula nova = new Celula(elemento, this.primeira);
      this.primeira!.Anterior = nova;
      this.primeira = nova;
    }
    this.totalDeElementos++;
  }

  public void Adiciona(Object elemento) { 
    if (this.totalDeElementos == 0) {
      this.AdicionaNoComeco(elemento);
    } else {
      Celula nova = new Celula(elemento);
      this.ultima!.Proximo = nova;
      nova.Anterior = this.ultima;
      this.ultima = nova;
      this.totalDeElementos++;
    }
  }

  private bool PosicaoOcupada(int posicao) { 
    return posicao >= 0 && posicao < this.totalDeElementos;
  }

  private Celula PegaCelula(int posicao) { 
    if (!this.PosicaoOcupada(posicao)) {
      throw new ArgumentException("Posição não existe");
    }

    Celula? atual = primeira;

    for (int i = 0; i < posicao; i++) {
      atual = atual!.Proximo;
    }

    return atual!;
  }

  public void Adiciona(int posicao, Object elemento) { 
    if (posicao == 0) {
      this.AdicionaNoComeco(elemento);
    } else if (posicao == this.totalDeElementos) {
      this.Adiciona(elemento);
    } else {
      Celula anterior = this.PegaCelula(posicao - 1);
      Celula proxima = anterior.Proximo!;

      Celula nova = new Celula(elemento, anterior.Proximo);
      nova.Anterior = anterior;
      anterior.Proximo = nova;
      proxima.Anterior = nova;
      this.totalDeElementos++;
    }
  }

  public Object Pega(int posicao) {
    return this.PegaCelula(posicao).Elemento;
  }

  public void Remove(int posicao) {
    if (posicao == 0) {
      this.RemoveDoComeco();
    } else if (posicao == this.totalDeElementos - 1) {
      this.RemoveDoFim();
    } else {
      Celula anterior = this.PegaCelula(posicao - 1);
      Celula atual = anterior.Proximo!;
      Celula proxima = atual.Proximo!;

      anterior.Proximo = proxima;
      proxima.Anterior = anterior;

      this.totalDeElementos--;
    }
  }

  public void RemoveDoComeco() { 
    if (totalDeElementos == 0) {
      throw new ArgumentException("Lista vazia");
    }

    this.primeira = this.primeira!.Proximo;
    this.totalDeElementos--;

    if (this.totalDeElementos == 0) {
      this.ultima = null;
    }
  }

  public void RemoveDoFim() { 
    if (totalDeElementos == 1) {
      this.RemoveDoComeco();
    } else {
      Celula penultima = this.ultima!.Anterior!;
      penultima.Proximo = null;
      this.ultima = penultima;
      this.totalDeElementos--;
    }
  }

  public int Tamanho() {
    return this.totalDeElementos;
  }

  public bool Contem(Object elemento) {
    Celula? atual = this.primeira;

    while (atual != null) {
      if (atual.Elemento.Equals(elemento)) {
        return true;
      }

      atual = atual.Proximo;
    }

    return false;
  }

  public override string ToString() {
    if (this.totalDeElementos == 0) {
      return "[]";
    }

    Celula? atual = primeira;

    StringBuilder builder = new StringBuilder("[");

    // Percorrendo até o penúltimo elemento.
    for (int i = 0; i < this.totalDeElementos - 1; i++) {
      builder.Append(atual!.Elemento);
      builder.Append(", ");
      atual = atual.Proximo;
    }

    // último elemento
    builder.Append(atual!.Elemento);
    builder.Append("]");

    return builder.ToString();
  }
}