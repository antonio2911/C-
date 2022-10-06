using System;

namespace Calculadora
{
  class Program
  {
 public static void Main(string[] args)
    {
    
      int[] array2 = new int[2]; // forma 1 de instanciar um vetor
     
      int soma1 = Calc.Soma(new int[] { 9, 9, 10 }); // forma compacta
     
      int soma2 = Calc.Soma(array2);

      int soma3 = Calc.Soma(1, 5, 7); // params

      Console.WriteLine($"soma1 = {soma1}, soma2 = {soma2}, soma3 = {soma3}");
    }
  }
}
