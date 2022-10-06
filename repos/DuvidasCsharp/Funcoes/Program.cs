using System;

namespace Funcoes
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Informe 3 numeros");
      int n1 = int.Parse(Console.ReadLine());
      int n2 = int.Parse(Console.ReadLine());
      int n3 = int.Parse(Console.ReadLine());
      int resultado = Maior(n1, n2, n3);
      Console.WriteLine($"O maior valor e = {resultado}");

      static int Maior(int x1,int x2,int x3)
      {
        int result;
        if(x1 > x2 && x1 > x3)
        {
          result = x1;
        }else if(x2 > x3)
        {
          result = x2;
        }
        else
        {
          result = x3;
        }
        return result;
      }
    }
  }
}
