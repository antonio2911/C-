using System;
using System.Globalization;

namespace DuvidasCsharp
{
  class Program
  {
    static void Main(string[] args)
    {
      //declaração de tipos
      string nome = "Antonio";
      char sexo = 'M';
      int idade = 21;
      double valor = 15.365465;
      float quebrado = 20.108642f;
      //imprimindo no console
      Console.Write(nome);
      Console.WriteLine(sexo);
      Console.WriteLine(idade);
      // limitador de casas decimais
      Console.WriteLine(valor.ToString("F2"));
      // formatar virgula para ponto(dot)
      Console.WriteLine(quebrado.ToString("F3", CultureInfo.InvariantCulture));
      //Placeholders
      Console.WriteLine("{0} tem {1} anos e {2} na carteira!",nome,idade,valor.ToString("F2"));
      //Concatenação
      Console.WriteLine(nome + " tem " + idade + " anos.");
      //Interpolação
      Console.WriteLine($"{nome} tem {idade} e {quebrado.ToString("F2", CultureInfo.InvariantCulture)} reais");



    }
  }
}
