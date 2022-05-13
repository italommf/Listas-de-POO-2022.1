using System;
class Program{
  public static void Main(){
    int x = MenorValor(4, 5, 2);
    Console.WriteLine(x);
    Console.WriteLine(MenorValor(8, 1, 5));
    int y = MenorValor(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
    Console.WriteLine(y);
  }
  public static int MenorValor(int a, int b, int c){
    int menor = a;
    if(b < menor) menor = b;
    if(c < menor) menor = c;
    return menor;
  }
}
