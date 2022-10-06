using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_exemplo
{
  class CircleCirculo : FiguraShape
  {
    public double Raio { get; set; }

    public CircleCirculo()
    {

    }

    public CircleCirculo(double raio,ColorEnum cor):base(cor)
    {
      Raio = raio;
    }
    public override double Area()
    {
      var area = Math.PI * Math.Pow(Raio,2);

      return area;
    }
  }
}
