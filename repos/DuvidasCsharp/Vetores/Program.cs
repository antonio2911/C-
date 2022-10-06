using System;
using System.Globalization;

namespace Vetores
{
  class Program
  {
    static void Main(string[] args)
    {
      //Vetores ler 3 alturas e tirar a media dessas auturas 

      Console.WriteLine("Digite a quantidade do vetor");
      int n = int.Parse(Console.ReadLine());

      double[] vetor = new double[n];

      for(int i = 0; i < n; i++)
      {
        Console.WriteLine($"Digite a altura da {i}º pessoa");
        vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      }

      double soma = 0.0;
      
      for(int i = 0; i< n; i++)
      {
        soma += vetor[i];
      }

      double media = soma / n;

      Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
    }
  }
}
