using System;

namespace Casting
{
  class Program
  {
    static void Main(string[] args)
    {
      //Atribuição
      int a = 10;
      Console.WriteLine(a++); // 10 depois adicionou 1
      Console.WriteLine(a); // 11
      a = 10;
      int b = ++a; // 11
      Console.WriteLine(b);

      //casting = conversão explicita de tipos
      //e tipo conjunto numerico ou seja
      // int e um float e um float e um double ou cabe dentro de um exemplo
      float x = 4.55f;
      double y = x;
      Console.WriteLine(y);

      //fazendo o casting
      double g = 10.5;
      float h = (float)g;
      Console.WriteLine(h);
      // ou
      int c = 5;
      int d = 2;
      double resultado = (float)c / d;
      Console.WriteLine(resultado);

      // metodos c#

      double elevado = Math.Pow(3, 2);
      Console.WriteLine(elevado);
      double raizQuadrada = Math.Sqrt(9);
      Console.WriteLine(raizQuadrada);
    }
  }
}
