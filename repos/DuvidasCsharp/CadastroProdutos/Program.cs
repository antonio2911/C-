using System;

namespace CadastroProdutos
{
  class Program
  {
    static void Main(string[] args)
    {
      Cadastro p = new Cadastro();
      p.Nome = "Banana";
      p.Preco = 2.00;
      p.Quantidade = 2;
      Console.WriteLine(p.ValorTotalEstoque());
      p.AdicionarProduto(10);
      Console.WriteLine(p.ValorTotalEstoque());
      p.RemoverProduto(10);
      Console.WriteLine(p.ValorTotalEstoque());
      Console.WriteLine(p);
    }
  }
}
