using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableCurse.Entities
{
  class Product : IComparable<Product>
  {
    public string Name { get; set; }
    public double Price { get; set; }

    public Product()
    {

    }

    public Product(string nome,double preco)
    {
      Name = nome;
      Price = preco;
    }

    public override string ToString()
    {
      return $"Nome do produto: {Name}, Preço do produto: {Price.ToString("F2", CultureInfo.InvariantCulture)}";
    }
    public int CompareTo(Product other)
    {
      if(!(other is Product))
      {
        throw new Exception("Não e um Produto");
      }
      else
      {
       // return Name.ToUpper().CompareTo(other.Name.ToUpper()); 
       // se quiser comparar o sort ou o equals pelo nome e so descomentar
        return Price.CompareTo(other.Price);
      }
    }
  }
}
