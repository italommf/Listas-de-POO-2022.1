using System;

public class Program{
  public static void Main(){
    int x;
    x = int.Parse(Console.ReadLine());
    
    if(x == 61){
      Console.WriteLine("Brasilia");}
    if(x == 71){
      Console.WriteLine("Salvador");}
    if(x == 11){
      Console.WriteLine("Sao Paulo");}
    if(x == 21){
      Console.WriteLine("Rio de Janeiro");}
    if(x == 32){
      Console.WriteLine("Juiz de Fora");}
    if(x == 19){
      Console.WriteLine("Campinas");}
    if(x == 27){
      Console.WriteLine("Vitoria");}
    if(x == 31){
      Console.WriteLine("Belo Horizonte");}
    
    if(x!= 61 && x != 71 && x != 11 && x!= 21 && x != 32 && x != 19 && x != 27 && x != 31){
      Console.WriteLine("DDD nao cadastrado");}
       
    
      
    }
  }
  
