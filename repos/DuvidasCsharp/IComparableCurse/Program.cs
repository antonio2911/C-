using IComparableCurse.Entities;
using System;
using System.Collections.Generic;

namespace IComparableCurse
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Product> lista = new List<Product>();
      List<MelhorImplementacao> listaDeProdutos = new List<MelhorImplementacao>();

      lista.Add(new Product { Name = "Tv", Price = 420.90 });
      lista.Add(new Product { Name = "Video Game", Price = 3200.00 });
      lista.Add(new Product { Name = "Notebook Lenovo", Price = 7400.50 });

      lista.Sort();

      foreach (Product item in lista)
      {
        Console.WriteLine(item);
      }

      // melhor implementação
      listaDeProdutos.Add(new MelhorImplementacao { Name = "Tv", Price = 420.90 });
      listaDeProdutos.Add(new MelhorImplementacao { Name = "Video Game", Price = 3200.00 });
      listaDeProdutos.Add(new MelhorImplementacao { Name = "Notebook Lenovo", Price = 7400.50 });

      listaDeProdutos.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));
      
      //so para didatica para funcionar e so descomentar
      // listaDeProdutos.Sort(CompareProducts);

      //static int CompareProducts(MelhorImplementacao productPrimary, MelhorImplementacao productSecondary)
      //{
      //  return productPrimary.Name.ToUpper().CompareTo(productSecondary.Name.ToUpper());
      //}

      listaDeProdutos.ForEach(item => Console.WriteLine($"Produto 2 = {item}"));

    }
  }
}
