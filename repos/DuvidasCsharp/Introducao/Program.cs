using Introducao.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Introducao
{
  class Program
  {
    static void Print<T>(string mensagem, IEnumerable<T> colecoes)
    {
      Console.WriteLine(mensagem);
      foreach(T obj in colecoes)
      {
        Console.WriteLine(obj);
      }
      Console.WriteLine();
    }
    static void Main(string[] args)
    {
      Category c1 = new Category() 
      {
        Id = 1,
        Name = "Ferramentas",
        Tier = 2
      };

      Category c2 = new Category(13, "Tools", 12);
      Category c3 = new Category(2, "Computador", 1);

      List<Product> products = new List<Product>() 
      {
        new Product(){Id = 1, Name="Computador", Price = 2930, Categoria = c1},
        new Product(){Id = 2, Name="Tools", Price = 300.90, Categoria = c2},
        new Product(){Id = 3, Name="Bussines", Price = 4560.80, Categoria = c3},
        new Product(){Id = 3, Name="Bike", Price = 460.80, Categoria = c3},
        new Product(){Id = 3, Name="Tela", Price = 45.70, Categoria = c3},
        new Product(){Id = 3, Name="Tela", Price = 900.00, Categoria = c3},
        new Product(){Id = 3, Name="Chave de Fenda", Price = 900.00, Categoria = c1},
        new Product(){Id = 3, Name="Chave Philips", Price = 900.00, Categoria = c1},
        new Product(){Id = 3, Name="Alicate", Price = 900.00, Categoria = c1}

      };

      var resultadoOne = products.Where(x => x.Categoria.Tier == 1 && x.Price < 900);

      Print("coleçoes", resultadoOne);

      // traz todos os objetos que tem a categoria igual a computador
      // para fazer um filtro mais refinado tipo o retorno desses objetos eu quero so o nome
      // uso o select
      var filtrarNomesCategoriaC3 = products.Where(p => p.Categoria.Name == "Computador").Select(p => p.Name);
      Print("Nomes dos produtos Categoria PC",filtrarNomesCategoriaC3);

      var produtosQueComecaComALetraC = products.Where(p => p.Name[0] == 'B').Select(p => new {p.Name,p.Price, alias =  p.Categoria.Name }); //selecao de varios campos com obj anonimo
      Print("Inicia com c", produtosQueComecaComALetraC);// porque não pode ter dois campos com nomes iguais no select

      var todasCategoriasOrdenadas = products.Where(p => p.Categoria.Tier == 1).OrderBy(p => p.Name).ThenBy(p => p.Price);

      Print("Filtrar pelo Tier == 1", todasCategoriasOrdenadas);

      // pula 2 elementos e pega os 4 seguintes
      var r5 = todasCategoriasOrdenadas.Skip(2).Take(4);


      // parte 2

      //quero o valor maximo baseado no preço ou no id por exemplo
      var maximoValor = products.Max(p => p.Price); // maior preço
      Console.WriteLine("preço maximo" + maximoValor); // pode descobri o minino usando o .Min()

      var SomarPeloIdCategoria = products.Where(p => p.Categoria.Id == 1).Sum(p => p.Price);

      Console.WriteLine("Soma total dos preços pelo id categoria" + SomarPeloIdCategoria);
    }
  }
}
