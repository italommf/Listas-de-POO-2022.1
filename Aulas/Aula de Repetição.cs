using System;
class Program{
  public static void Main(){

//LAÇO 1
/*
    int x = 1;
    while(x < 100){ // aqui o teste do while é feito no início
      Console.WriteLine(x);
      x++;

*/

//LAÇO 2
 /*

    for(int x = 0; x <= 100; x++){
      Console.WriteLine(x);
    }

*/

/*
    int x = 20;
    do{
      Console.WriteLine(x); // aqui, o teste do while é feito no final
      x++;
    } while(x <= 30);
*/
    
    string s = "Atensaun Todos os Robso"; //imprime cada caracter ou item de um vetor     
      foreach(char c in s)
        Console.WriteLine(c);

    Console.WriteLine(); //imprime linha vazia
    int[] vetor = {1, 4, 6, 8, 3, 6, 7};
    Array.Sort(vetor); // ordena o vetor criado
    foreach(int l in vetor)
      Console.WriteLine(l);
  
  }
}

