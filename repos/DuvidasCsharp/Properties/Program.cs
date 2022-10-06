using System;

namespace Properties
{
  class Program
  {
    static void Main(string[] args)
    {
      // properties e uso do this.
      ProdutoEncapsulamento produto = new ProdutoEncapsulamento("antonio", 23.00, 25);

      Console.WriteLine(produto.GetName(), produto.GetPrice());

      produto.SetName("Toninho");

      Console.WriteLine(produto.GetName());

      Properties produtoTeste = new Properties();

      produtoTeste.Nome = "Toninho";
      produtoTeste.Preco = 12.30;
      Console.WriteLine(produtoTeste.Quantidade ); 
    }
  }
}
