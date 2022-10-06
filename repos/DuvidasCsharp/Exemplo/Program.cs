using System;
using System.Collections;
using System.Linq;

namespace Exemplo
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] numbers = new int[] { 0, 2, 3, 4, 5, 6, 7, 8 };

      // where = todos os pares / select numeros pares x 10
      IEnumerable result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);


    }
  }
}
