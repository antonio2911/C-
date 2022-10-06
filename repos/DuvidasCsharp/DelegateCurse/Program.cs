using DelegateCurse.Services;
using System;

namespace DelegateCurse
{
  
  class Program
  {
    static void Main(string[] args)
    {
      double a = 10;
      double b = 15.50;
      OperacaoNumericaBinaria op = CaculationServices.Max;

      double result = CaculationServices.Sum(a, b);
      Console.WriteLine(result);
      Console.WriteLine(CaculationServices.Square(b));
      Console.WriteLine(op(a,b));

    }
  }
}
