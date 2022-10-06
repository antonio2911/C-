using System;
using System.Collections.Generic;

namespace Listas
{
  class Program
  {
    static void Main(string[] args)
    {
      List<string> lista = new List<string>();

      // Adicionar elementos
      lista.Add("Antonio");
      lista.Add("Aline");
      lista.Add("Joyce");
      lista.Add("Berenice");
      lista.Add("Augusto");
      lista.Add("Joana");

      // pecorer os nomes
      foreach(var nome in lista)
      {
        Console.WriteLine(nome);
      }
      // inseri indicando o indice da lista
      lista.Insert(2, "Junio");

      string nome1 = lista.Find(x => x[1] == 'n');
      Console.WriteLine($"PRIMEIRA OCORRENCIA DO NOME ONDE O INDICE 1 DA STRING = N {nome1}");

      string nome2 = lista.FindLast(x => x[0] == 'J');
      Console.WriteLine($"segundo nome: {nome2}");

     int nome3 = lista.FindIndex(a => a[0] == 'J');

     int nome4 = lista.FindLastIndex(a => a[0] == 'J');
      Console.WriteLine($"condição do index da primeira ocorrencia {nome3} e ultima ocorrencia {nome4}");
       
      // x tal que x.lenght == 5
      List<string> nome5 = lista.FindAll(b => b.Length == 5);

      Console.WriteLine("_____________________________________");

      foreach(var item in nome5)
      {
        Console.WriteLine(item);
      }

      // remover nomes da lista

      lista.Remove("Berenice");

      Console.WriteLine("-------------------------------------------");
      foreach(var item in lista)
      {
        Console.WriteLine(item);
      }

      //remover todos espera um predicado = (expressão lambida)

      lista.RemoveAll(remover => remover[0] == 'A');

      Console.WriteLine("-------------------------------------------");
      foreach (var item in lista)
      {
        Console.WriteLine(item);
      }
      lista.Add("Veronica");
      lista.Add("Stephanie");
      lista.Add("Marcos");

      // removeAt = remove passando o indice
      Console.WriteLine("RemoveAt");
      lista.RemoveAt(0); 

      Console.WriteLine("-------------------------------------------");
      foreach (var item in lista)
      {
        Console.WriteLine(item);
      }

      // remove range = define o intervalo de 0, 4 = inicio e fim contando com a posição inicial
      Console.WriteLine("Remove Range");

      // a partir do indice 3 remove 2 elementos
      lista.RemoveRange(3, 2);
      Console.WriteLine("-------------------------------------------");
      foreach (var item in lista)
      {
        Console.WriteLine(item);
      }
    }
  }
}
