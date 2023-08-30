using Entities;

namespace Ds.Collections;
public class Vector
{
  private Aluno[] alunos = new Aluno[100];
  private int totalAlunos = 0;

  public void Add(Aluno aluno){
    alunos[totalAlunos] = aluno;
    totalAlunos++;
  }

  private bool ValidPosition(int posicao){
    return posicao >= 0 && posicao <= totalAlunos;
  }
  public void Add(int posicao, Aluno aluno){
    if(!ValidPosition(posicao))
      throw new ArgumentException("Posição inválida");

    for(int i = totalAlunos - 1; i >= posicao; i--){
      alunos[i + 1] = alunos[i];
    }
    alunos[posicao] = aluno;
    totalAlunos++;
  }

  private bool OccupiedPosition(int posicao){
    return posicao >= 0 && posicao < totalAlunos;
  }
  public Aluno? Get(int index){
    if(!OccupiedPosition(index))
      throw new ArgumentException("Posição inválida");
    return alunos[index];
  }

  public void Remove(int position){
    for(int i = position; i < totalAlunos; i++){
      alunos[i] = alunos[i + 1];
    }
    totalAlunos--;
  }

  public bool Contains(Aluno aluno){
    for(int i = 0; i < totalAlunos; i++){
      if(alunos[i].Equals(aluno))
        return true;
    }
    return false;
  }

  public int Size(){
    return totalAlunos;
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
