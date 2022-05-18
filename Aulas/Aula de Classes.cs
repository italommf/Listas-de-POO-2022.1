using System;
class Program{
  public static void Main(){
    
    Aluno a1 = new Aluno();
    a1.nome = "Italo";
    a1.idade = 23;
    Console.WriteLine(a1.idade);
    Console.WriteLine(a1.nome);
    Console.WriteLine(a1.dias()); 
    a1 = null; // apos executar o programa, a variavel desacarrega e libera o espaço de memoria antes ocupado.
    
  }
}

class Aluno{
  
  public string nome;
  public string matricula;
  public int idade;

  public int dias(){
    return idade*360;
  }
  
}