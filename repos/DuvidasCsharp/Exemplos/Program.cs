using Exemplos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exemplos
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Products> lista = new List<Products>();

      lista.Add(new Products("Tv", 4200));
      lista.Add(new Products("Som", 632));
      lista.Add(new Products("DVD", 450.60));
      lista.Add(new Products("Home", 1800.00));
      //Predicate function
      lista.RemoveAll(p => p.Price > 632.00);

      foreach(Products produto in lista)
      {
        Console.WriteLine(produto);
      }
      //Func exemple do linq
     // Func<Products, string> func = NameUpper;
      List<string> funcoesDaLista = lista.Select(p => p.Name.ToUpper()).ToList();
     //outra forma de fazer a expressão lambda com o returm
      //List<string> funcoesDaLista = lista.Select(p => {return p.Name.ToUpper()}).ToList();


    }
    //static string NameUpper(Products p)
    //{
    //  return p.Name.ToUpper();
    //}
  }
}
