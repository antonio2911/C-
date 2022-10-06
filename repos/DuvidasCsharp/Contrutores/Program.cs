using CadastroProdutos;
using System;

namespace Contrutores
{
  class Program
  {
    static void Main(string[] args)
    {
      Cadastro p = new Cadastro("Banana", 2.00,2);

      Console.WriteLine(p.ValorTotalEstoque());
      p.AdicionarProduto(10);
      Console.WriteLine(p.ValorTotalEstoque());
      p.RemoverProduto(10);
      Console.WriteLine(p.ValorTotalEstoque());
      Console.WriteLine(p);
      // Construtores
      //os Construtores serve para obrigar um usuario criar um produto com as definições. nesse cenario não criar produto vazio
      Cadastro p2 = new Cadastro("TV",5.500,3);
      Cadastro p3 = new Cadastro("DVD", 3000);

      Console.WriteLine(p2);
      Console.WriteLine(p3);
    }
  }
}
