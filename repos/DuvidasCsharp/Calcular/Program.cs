using System;

namespace Calcular
{
  class Program
  {
    static void Main(string[] args)
    {
      Calculadora calcular = new Calculadora();
      
      Console.WriteLine(calcular.dobraOValor(30));
    }
  }
}
