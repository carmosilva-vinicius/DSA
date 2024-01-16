namespace Entities;
public class Aluno
{
  private string Nome { get; set; }

    public Aluno(string nome)
    {
        Nome = nome;
    }

    public override bool Equals(object? obj)
    {
        return obj is Aluno aluno &&
          Nome == aluno.Nome;
    }

    public override string ToString()
    {
        return Nome;
    }
}
