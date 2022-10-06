using System;

namespace Matrizes
{
  class Program
  {
    static void Main(string[] args)
    {
      double[,] matriz = new double[2, 3];


      Console.WriteLine($"Quantidades de elementos na matriz {matriz.Length}");

      Console.WriteLine($"Quantidades de linhas {matriz.Rank}");

      Console.WriteLine($"Quantidades de elementos na primeira dimensão {matriz.GetLength(0)}");

      Console.WriteLine($"Quantidades de elementos na segunda dimensão {matriz.GetLength(1)}");
    }
  }
}
