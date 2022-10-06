using System;
using System.Globalization;

namespace EntradaDeDados
{
  class Program
  {
    static void Main(string[] args)
    {
      //o retorno e do tipo string sempre

      string frase = Console.ReadLine();
      Console.WriteLine(frase);

      //split = quebra a string em varios pedaços e inserir na posição de um vetor 
      string[] vetor = frase.Split(" ");
      string p1 = vetor[0];
      string p2 = vetor[1];
      string p3 = vetor[2];
      Console.WriteLine($"vetor p1 = {p1}, p2 = {p2}, p3 = {p3}");

      //outra forma de usar o split
      string[] nomes = Console.ReadLine().Split(" ");
      Console.WriteLine(nomes.Length);

      //converter entradas de dados

      Console.WriteLine("digite um valor inteiro");
      int n1 = int.Parse(Console.ReadLine());

      Console.WriteLine("digite um caractere");
      char caractere = char.Parse(Console.ReadLine());

      Console.WriteLine("digite um valor double com virgular");
      double n2 = double.Parse(Console.ReadLine());

      Console.WriteLine("digite um valor float com ponto");
      float n3 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      Console.WriteLine($"Leitura = (int = {n1}, char = {caractere}, double = {n2}, float = {n3.ToString("F2", CultureInfo.InvariantCulture)})");
    }
  }
}
