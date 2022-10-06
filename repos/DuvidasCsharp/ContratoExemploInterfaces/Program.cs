using ContratoExemploInterfaces.Entities;
using ContratoExemploInterfaces.Services;
using System;
using System.Globalization;

namespace ContratoExemploInterfaces
{
  class Program
  {
    static void Main(string[] args)
    {
      //Aluguel de veiculo
      // Modelo do Carro
      //Data de entrada
      //Data saida
      //Valor por hora
      //Preço diaria
      // nota fiscal
      //valor 
      // taxa
      // total do pagamento

      Console.WriteLine("dados");
      Console.WriteLine("Modelo");
      string modelo = Console.ReadLine();
      Console.WriteLine("Data Inicio dd / MM / yyyy HH: mm");
      DateTime dataInicio = DateTime.Parse(Console.ReadLine());
      Console.WriteLine("Data Fim dd / MM / yyyy HH: mm");
      DateTime dataFim = DateTime.Parse(Console.ReadLine());
      Console.WriteLine("Informe o preço por hora!");
      double precoPorHora = double.Parse(Console.ReadLine());
      Console.WriteLine("Informe o preço por Dia!");
      double precoPorDia = double.Parse(Console.ReadLine());

      AluguelDoVeiculo carroAluguel = new AluguelDoVeiculo(dataInicio, dataFim, new Veiculo(modelo));

      ServicoDeAluguel serviceRental = new ServicoDeAluguel(precoPorHora,precoPorDia, new TaxaBrasil());

      serviceRental.ProcessarPagamento(carroAluguel);
      Console.WriteLine("Fatura");
      Console.WriteLine(carroAluguel.Fatura);
    }
  }
}
