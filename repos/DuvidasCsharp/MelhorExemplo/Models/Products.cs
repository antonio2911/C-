using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelhorExemplo.Models
{
  class Products : IComparable
  {
    public string Nome { get; set; }
    public double Preco { get; set; }

    public Products()
    {

    }

    public Products(string nome, double preco)
    {
      Nome = nome;
      Preco = preco;
    }

    public override string ToString()
    {
      return $@"Nome: {Nome}
                Preço: {Preco.ToString("F2", CultureInfo.InvariantCulture)}";
    }

    public int CompareTo(object obj)
    {
      if(!(obj is Products))
      {
        throw new ArgumentException("Esse Argumento não e um produto");
      }
      Products other = obj as Products;
      return Preco.CompareTo(other.Preco);
    }
  }
}
