using System;

namespace Nullable
{
  class Program
  {
    static void Main(string[] args)
    {
      //formas de declarar o que valor pode ser nulo
      
      Nullable<double> x = null;
      
      double? y = null;
      double? z = 15; 
      Console.WriteLine($"Valor de x = {x}");
      Console.WriteLine($"Valor de y = {y}");

      //Operador de coalencia

      double a = y ?? 0.0; /// se y = null ele atribui 00
      double b = z ?? 0.0;

      //operações do operador nullable

      Console.WriteLine(x.GetValueOrDefault()); // pega o valor caso for null pega o valor padrão do atributo = 0
      Console.WriteLine(z.GetValueOrDefault());

      Console.WriteLine(y.HasValue); // retorna um boolean se existe valor = true se não existe(null) = false
      Console.WriteLine(z.HasValue);

      Console.WriteLine($"Operador se e nullable a = {a} e b = {b}");

      //Pega o valor real dentro da variavel se e null retorna um erro por esse motivo e usado com um if
      //Console.WriteLine(x.Value);
      //Console.WriteLine(z.Value);

      if(x.HasValue)
        Console.WriteLine(x.Value);
      else
        Console.WriteLine("O valor de x e nullable");

      if(z.HasValue)
        Console.WriteLine(z.Value);
      else
        Console.WriteLine("O valor de z e nullable");

    }
  }
}
