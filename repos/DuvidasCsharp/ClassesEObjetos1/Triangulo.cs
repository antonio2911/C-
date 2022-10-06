using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEObjetos1
{
  class Triangulo
  {
    public double A;
    public double B;
    public double C;

    
    public double Area()
    {
      double P = (A + B + C) / 2.00;
      double resultado = Math.Sqrt(P * (P - A) * (P -B) * (P - C));
      return resultado;
    }
   
  }
}
