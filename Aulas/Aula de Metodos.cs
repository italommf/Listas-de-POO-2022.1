using System;
class Program{
  public static void Main(){
    //int x = MenorValor(4, 5, 2);
    //Console.WriteLine(x);
    //Console.WriteLine(MenorValor(8, 1, 5));
    int y = MenorMaiorValor(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
    Console.WriteLine(y);
  }
  public static int MenorMaiorValor(int a, int b, int c, out int menor, out int maior){
    int menor = a;
    if(b < menor) menor = b;
    if(c < menor) menor = c;
    int maior = a;
    if(b > maior) maior = b;
    if(c > maior) maior = c;
    }
}
