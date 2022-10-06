using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_exemplo
{
  class Retangulo : FiguraShape
  {
    public double WidthLargura { get; set; }
    public double HeigthAltura { get; set; }

    public Retangulo()
    {

    }

    public Retangulo(double largura,double altura, ColorEnum cor): base(cor)
    {
      WidthLargura = largura;
      HeigthAltura = altura;
    }

    public override double Area()
    {
      var area = WidthLargura * HeigthAltura;

      return area;
    }
  }
}
