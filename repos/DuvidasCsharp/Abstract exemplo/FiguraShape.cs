using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_exemplo
{
  // class abstrata não pode ser instanciada ex: new FiguraShape() mas pode ser herdada
  // metodos abstratos => obrigado a ser implementado e deve ser sobrescrito 
  abstract class FiguraShape
  {
    public ColorEnum ColorFigura { get; set; }

    public FiguraShape()
    {

    }

    public FiguraShape(ColorEnum cor)
    {
      ColorFigura = cor;
    }
    // quanto o metodo e abstrato a class por obrigatoriedade tem que ser abstrata tambem
    // o metodo abstrato por padrão ja e virtual ou seja ele tem a obrigatoriedade de ser implementada por
    // quem herda a class e deve utilizar o override
    public abstract double Area();
  }
}
