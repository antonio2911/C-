using CursoExtension.Extensions;
using System;

namespace CursoExtension
{
  class Program
  {
    static void Main(string[] args)
    {
      DateTime dt = new DateTime(2022,09,13,18,53,00);
      Console.WriteLine(dt.cursoExtension());

      //corta string extension

      Console.WriteLine("digite o texto");
      string texto = Console.ReadLine();
      Console.WriteLine("numero inteiro do tamanho do corte");
      int corte = int.Parse(Console.ReadLine());

      Console.WriteLine(texto.Cut(corte));
    }
  }
}
