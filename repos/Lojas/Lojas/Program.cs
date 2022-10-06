using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lojas
{
  public class Program
  {
    public static void Main(string[] args)
    {
      GravarUsandoEnity()
    }

    private static void GravarUsandoEnity()
    {
      Produto p = new Produto();
      p.Nome = "Harry Potter e a Ordem da Fênix";
      p.Categoria = "Livros";
      p.Preco = 19.89;

      using (var contexto = new LojaContext())
      {
        contexto.produtos.Add(p);
        contexto.SaveChanges();
      }
    }
  }
}
