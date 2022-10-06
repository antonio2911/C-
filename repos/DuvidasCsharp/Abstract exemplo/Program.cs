using Abstract_exemplo;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace AbstractExemplo
{
  class Program
  {
    static void Main(string[] args)
    {
      List<FiguraShape> objeto = new List<FiguraShape>();

      Console.WriteLine("Numero de objetos");
      int numerosDeObjetos = int.Parse(Console.ReadLine());
      Console.WriteLine("Retangulo ou Circulo digite (r/c)");
      char rectangleOrCircle = char.Parse(Console.ReadLine());

      for(int i = 0; i < numerosDeObjetos; i++)
      {
        if(rectangleOrCircle == 'r')
        {
          Console.WriteLine("Informe a Largura do Rectangle");
          double largura = double.Parse(Console.ReadLine());
          Console.WriteLine("Informe a Altura do Rectangle");
          double altura = double.Parse(Console.ReadLine());
          Console.WriteLine("Black/Blue/Red");
          ColorEnum cor = Enum.Parse<ColorEnum>(Console.ReadLine());
          objeto.Add(new Retangulo(largura,altura,cor));
        }
        if(rectangleOrCircle == 'c')
        {
          Console.WriteLine("Informe o Raio");
          double raio = double.Parse(Console.ReadLine());
          Console.WriteLine("Black/Blue/Red");
          ColorEnum cor = Enum.Parse<ColorEnum>(Console.ReadLine());
          objeto.Add(new CircleCirculo(raio,cor));
        }
      }

      objeto.ForEach(area =>
      {
        Console.WriteLine(area.Area().ToString("F2", CultureInfo.InvariantCulture));
      });

    }
  }
}
