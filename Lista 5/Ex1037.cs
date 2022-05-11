using System;
public class Program{
  public static void Main(){
    float x = float.Parse(Console.ReadLine());
    if(0<=x<=25) Console.Writeline("Intervalo (0,25]");
    if(25<x<=50) Console.WriteLine("Intervalo (25,50)")
  }
}