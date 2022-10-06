using System.Globalization;

namespace Implementacao.Entities
{
  class Rectangle : AbstractShape
  {
    public double Base { get; set; }
    public double Altura { get; set; }
    
    public override double Area()
    {
      return Base * Altura;
    }

    public override string ToString()
    {
      return $@"Base: {Base}
                Altura: {Altura}
                Area: {Area().ToString("F2", CultureInfo.InvariantCulture)}";
    }
  }
}
