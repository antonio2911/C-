using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introducao.Entities
{
  class Product
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public Category Categoria { get; set; }

    public Product()
    {

    }
    public Product(int id, string name, double price)
    {
      Id = id;
      Name = name;
      Price = price;
    }

    public override string ToString()
    {
      return @$" Nome:{Name}, Id: {Id}, Preço: {Price},
                  Categoria: {Categoria.Id}, Tier: {Categoria.Tier}";
    }
  }
}
