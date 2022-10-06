using System;
using System.Globalization;

namespace SwitchCase
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Digite o dia da semana");

      int x = int.Parse(Console.ReadLine());

      string day;

      double valor, desconto;

      while(x != 0)
      {
        switch (x)
        {
          case 1:
            day = "Sunday";
            break;
          case 2:
            day = "Monday";
            break;
          case 3:
            day = "Tuesday";
            break;
          case 4:
            day = "Wednesday";
            break;
          case 5:
            day = "Thursday";
            break;
          case 6:
            day = "Friday";
            break;
          case 7:
            day = "Saturday";
            break;
          default:
            day = "Invalid value";
            break;
        }
        Console.WriteLine(day);
        Console.WriteLine("Digite 0 para finalizar o programa.");
        x = int.Parse(Console.ReadLine());
      }

      Console.WriteLine("Calculo de desconto");

      Console.WriteLine("Digite o valor");

      valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      desconto = (valor < 20.00) ? valor * 0.1 : valor * 0.05;

      Console.WriteLine($"O valor do desconto e {desconto.ToString("F2")}");
      
    }
  }
}
