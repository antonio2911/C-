using System;

namespace Ref
{
  class Program
  {
    static void Main(string[] args)
    {
      int a = 10;
      int b;
      Tripicar.Tripica(ref a);
      Console.WriteLine(a);

      Tripicar.TripicaComRetorno(ref a, out b);

      Console.WriteLine(b);
    }
  }
}
