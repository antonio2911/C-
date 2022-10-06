using Implementacao.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementacao.Entities
{
 abstract class AbstractShape : Ishape
  {
    public ColorEnum Color { get; set; }

    //por ser uma interface e obrigado a implementar o metodo area porem como e abstrato e obrigado ser declarado
    // porem como e abstract e obrigado implementar vazio para ser sobrescrito
    public abstract double Area();
  }
}
