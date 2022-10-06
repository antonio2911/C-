using System;
using System.Globalization;

namespace Implementacao.Entities
{
  class Circle : AbstractShape
  {
    public double Raio { get; set; }


    public override double Area()
    {
      return Math.PI * Math.Pow(Raio, 2);
    }

    public override string ToString()
    {
      return $@"Raio do circle: {Raio},
                Cor: {Color},
                Area do circle: {Area().ToString("F2", CultureInfo.InvariantCulture)}";
    }
  }
}
