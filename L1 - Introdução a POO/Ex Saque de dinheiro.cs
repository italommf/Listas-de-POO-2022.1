using System;
class Program {
  public static void Main(){
    
    DadosBancarios x = new DadosBancarios();
    x.nome = "Italo";
    x.nconta = "4002-abc";
    x.saldo = 0.75;
    x.depositar(7);
    Console.WriteLine("Dados da conta");
    Console.WriteLine(x.nome);
    Console.WriteLine(x.nconta);
    Console.WriteLine("Saldo após o depósito");
    Console.WriteLine(x.saldo);
    x.sacar(2);
    Console.WriteLine("Saldo após o saque");
    Console.WriteLine(x.saldo);
  }
}

class DadosBancarios{
  public string nome;
  public string nconta;
  public double saldo;
  public void depositar(double valor){
    saldo += valor;
  }
  public void sacar(double valor){
    saldo -= valor;
  }
}