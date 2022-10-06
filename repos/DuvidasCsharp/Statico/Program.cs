using System;
using System.Globalization;

namespace Statico
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Entre com o valor do raio");
      double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      double continuar = 1;
      while (continuar == 1)
      {
        double circ = Calculadora.Circunferencia(raio);
        double vol = Calculadora.Volume(raio);

        Console.WriteLine($"Circunferencia: {circ.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Volume: {vol.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"PI: {Calculadora.Pi}");
        Console.WriteLine("Entre com o valor do raio");
        raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Digite 1 para continuar e 2 para sair.");
        continuar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      }
     


    }
  }
}
