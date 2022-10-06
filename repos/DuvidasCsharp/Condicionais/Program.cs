using System;

namespace Condicionais
{
  class Program
  {
    static void Main(string[] args)
    {
      bool c1 = 5 > 10 && 10 != 5;
      Console.WriteLine(c1);
      bool c2 = 5 > 10 && 10 != 5 || 10 == 10;
      bool c3 = !c2;
      
      Console.WriteLine("Ordem de precedencia primeiro resolve o && e depois o ||");
      Console.WriteLine("primeiro = (5 > 10 && 10 != 5 = false)  (false || true) = true");
      Console.WriteLine(c2);
      Console.WriteLine($"Operador de negação ! = {c3}");

      // saber se e impar ou par
      Console.WriteLine("Digite um valor para saber se e impar ou par");
      int valor = int.Parse(Console.ReadLine());
      if(valor % 2 == 0)
      {
        Console.WriteLine($"O numero {valor} e par!");
      }
      else
      {
        Console.WriteLine($"O numero {valor} e impar!");
      }

      // programa do bom dia / boa tarde / boa noite
      Console.WriteLine("informe apenas a hora atual em um valor inteiro formato 24 horas");
      int horas = int.Parse(Console.ReadLine());
      if(horas < 12)
      {
        Console.WriteLine("Bom Dia");
      }else if(horas < 18){
        Console.WriteLine("Boa Tarde");
      }
      else if (horas < 23)
      {
        Console.WriteLine("Boa noite");
      }
      else
      {
        Console.WriteLine("horario incorreto favor informar as horas em formato de 24 horas");
      }

    }
  }
}
