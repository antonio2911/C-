using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos.Entities
{
  class Products
  {
    public string Name { get; set; }
    public double Price { get; set; }

    public Products(string name, double price)
    {
      Name = name;
      Price = price;
    }

    public override string ToString()
    {
      return $"Name: {Name}, Preço: {Price}";
    }

    
  }
}
