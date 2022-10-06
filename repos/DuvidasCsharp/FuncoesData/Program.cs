using System;
using System.Globalization;

namespace FuncoesData
{
  class Program
  {
    static void Main(string[] args)
    {
      // o date time na verdade e uma string de nanosegundos
      DateTime d1 = DateTime.Now; // instante atual do sistema

      Console.WriteLine(d1);

      // para saber o valor em nanosegundo

      Console.WriteLine(d1.Ticks); // para saber o valor em nanosegundo do now

      DateTime d2 = new DateTime(2018,11,25);
      DateTime d3 = new DateTime(2019, 11, 29, 20, 45, 3);
      DateTime d4 = DateTime.UtcNow; // horario padrão no meridiano de greenwich
      DateTime d5 = DateTime.Today; // data de hoje e horario zerado
      DateTime d6 = DateTime.Parse("2020-08-21"); // converte um formato de data para o formato de datetime pega automatico => formato banco
      DateTime d7 = DateTime.Parse("13/07/2022"); // formato brasileiro
      DateTime d8 = DateTime.ParseExact("2020-15-08", "yyyy-dd-MM", CultureInfo.InvariantCulture); // formato personalidado você define o formado do dateTime
      DateTime d9 = DateTime.ParseExact("13/07/2022 18:27:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
      Console.WriteLine(d1);
      Console.WriteLine(d2);
      Console.WriteLine(d3);
      Console.WriteLine(d4);
      Console.WriteLine(d5);
      Console.WriteLine(d6);
      Console.WriteLine(d7);
      Console.WriteLine(d8);
      Console.WriteLine(d9);

    }
  }
}
