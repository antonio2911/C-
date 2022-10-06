using System;
using System.Globalization;

namespace VetoresParte2
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Digite a quantidade do vetor");
      int quantidade = int.Parse(Console.ReadLine());
      Produto[] produtos = new Produto[quantidade];

      for (int i = 0; i < quantidade; i++)
      {
        Console.WriteLine("Digite o nome do produto");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite o preço do produto");
        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        produtos[i] = new Produto
        {
          Nome = nome,
          Preco = preco
        };
      }

      double soma = 0.0;

      for(int i = 0; i < quantidade; i++)
      {
        soma += produtos[i].Preco;
      }

      Console.WriteLine($"O valor total dos produtos e {soma}");
    }
  }
}
