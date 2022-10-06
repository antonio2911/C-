using System;
using System.Globalization;

namespace ClassesEObjetos1
{
  class Program
  {
    static void Main(string[] args)
    {
      // calculo da area do triangulo
      Triangulo X = new Triangulo();
      Triangulo Y = new Triangulo();
      Console.WriteLine("Digite as medidas do triangulo X.");
      X.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      X.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      X.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.WriteLine("Digite as medidas do triangulo Y.");
       Y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
       Y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
     
      Console.WriteLine($"Area do triangulo X = {X.Area().ToString("F2", CultureInfo.InvariantCulture)}");
      Console.WriteLine($"Area do triangulo Y = {Y.Area().ToString("F2", CultureInfo.InvariantCulture)}");
     
      if(X.Area() > Y.Area())
      {
        Console.WriteLine($"A maior area e a de X = {X.Area()}");
      }
      else
      {
        Console.WriteLine($"A maior area e a de Y = {Y.Area()}");
      }
      
    }
  }
}
