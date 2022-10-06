using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableCurse.Entities
{
  class MelhorImplementacao
  {
    public string Name { get; set; }
    public double Price { get; set; }

    public MelhorImplementacao()
    {

    }

    public MelhorImplementacao(string name, double price)
    {
      Name = name;
      Price = price;
    }

    public override string ToString()
    {
      return $"Nome: {Name}, Preço: {Price}";
    }
  }
}
