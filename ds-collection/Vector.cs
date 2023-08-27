using Entities;

namespace Ds.Collections;
public class Vector
{
  private Aluno[] alunos = new Aluno[100];

  public void Add(Aluno aluno){}

  public Aluno? Get(int index){
    return null;
  }

  public void Remove(Aluno aluno){}

  public bool Contains(Aluno aluno){
    return false;
  }

  public int Size(){
    return 0;
  }

  public override string ToString(){
    string arrayString = "";
    foreach (var aluno in alunos)
    {
      arrayString += aluno + ", ";
    }
    return arrayString;
  }
}
