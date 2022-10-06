using GetHastCodeExemplo.Entities;
using System;

namespace GetHastCodeExemplo
{
  class Program
  {
    static void Main(string[] args)
    {
      Clients a = new Clients { Nome = "Maria", Email = "maria@shop" };
      Clients b = new Clients { Nome = "Alex", Email = "maria@shop" }; // deixar o email igual e comparar os resultados

      Console.WriteLine(a.Equals(b));// sobrescrito comparando o conteudo do criterio
      Console.WriteLine(a == b); // compara referencia do ponteiro de memoria do objeto
      Console.WriteLine(a.GetHashCode()); // emails iguais retorna true (metodos sobrescrito)
      Console.WriteLine(b.GetHashCode());
    }
  }
}
