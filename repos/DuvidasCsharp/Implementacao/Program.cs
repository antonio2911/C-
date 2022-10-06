using Implementacao.Entities;
using Implementacao.Enuns;
using System;

namespace Implementacao
{
  class Program
  {
    static void Main(string[] args)
    {
      Ishape circulo = new Circle() { Raio = 3.5, Color = ColorEnum.White };
      Ishape retangulo = new Rectangle() { Altura = 10.00, Base = 30.00, Color = ColorEnum.Black };

      Console.WriteLine(circulo);
      Console.WriteLine(retangulo);
    }
  }
}
