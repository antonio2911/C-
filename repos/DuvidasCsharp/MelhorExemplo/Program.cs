using MelhorExemplo.Entities;
using MelhorExemplo.Models;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace MelhorExemplo
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Quantidades de numeros na lista:");

      int quantidade = int.Parse(Console.ReadLine());
      List<Products> produtos = new List<Products>();
      CalculationServices maximo = new CalculationServices();

     for(int i = 0; i < quantidade; i++)
      {
        Console.WriteLine($"Informe nome e preço separado por virgula do {i}º valor!");
        string[] vetor = Console.ReadLine().Split(",");
        string nome = vetor[0];
        double price = double.Parse(vetor[1], CultureInfo.InvariantCulture);
        produtos.Add(new Products(nome, price));
      }
      Products max = maximo.Max(produtos);
      Console.WriteLine($"Maior Valor da Lista: {max}"); 
    }
  }
}
