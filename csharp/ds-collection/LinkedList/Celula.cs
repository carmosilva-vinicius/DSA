
public class Celula
{
  public Object Elemento { get; }
  public Celula? Anterior { get; set; }
  public Celula? Proximo { get; set; }

  public Celula(Object elemento)
  {
    this.Elemento = elemento;
    this.Proximo = null;
  }
  public Celula(Object elemento, Celula? proximo)
  {
    this.Elemento = elemento;
    this.Proximo = proximo;
  }
}