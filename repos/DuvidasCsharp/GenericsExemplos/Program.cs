using GenericsExemplos.Services;
using System;
using System.Collections.Generic;

namespace GenericsExemplos
{
  class Program
  {
    static void Main(string[] args)
    {
      char VariavelDeComando = 'n';
      PrintService lista = new PrintService();
    
      while(VariavelDeComando != 's')
      {
        Console.WriteLine("Digite um numero");
        int valorNumerico = int.Parse(Console.ReadLine());
        lista.AddValue(valorNumerico);
        Console.WriteLine("Deseja continuar? s/n");
        VariavelDeComando = char.Parse(Console.ReadLine().ToLower());
      }

      Console.WriteLine(lista.First());
      Console.WriteLine(lista.Print());

    }
  }
}
