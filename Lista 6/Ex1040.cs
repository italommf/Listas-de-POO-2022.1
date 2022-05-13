using System;
public class program{
  public static void Main(){

    string frase = Console.ReadLine().ToUpper(); // variavel.ToUpper() devolve a string toda em maiúscula.
    while (frase != "*"){
      bool ok = true;
      
      char c = frase[0];
      
      for(int k = 0; k < frase.Length; k++){
        if(frase[k] == ' ' && frase[k+1] != c){
          ok = false;          
        }
      }    
    }   
  }
}