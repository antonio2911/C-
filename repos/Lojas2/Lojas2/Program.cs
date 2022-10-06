using System;

namespace Lojas2
{
  class Program
  {
    static void Main(string[] args)
    {
      GravarSql();
    }
      private static void GravarSql()
    {
      Produto p = new Produto();
      p.Nome = "Dexter";
      p.Categoria = "Investigativo";
      p.Preco = 30.89;
      using (var contexto = new LojaContext())
      {
        contexto.Produtos.Add(p);
        contexto.SaveChanges();
      }

    }
  }
}
