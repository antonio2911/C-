using System;

namespace TechMeet
{
  class Program
  {
    static void Main(string[] args)
    {
      Pista pista = new Pista("Interlagos");

      int velocidadeDaVolta = int.Parse(Console.ReadLine());

      if(velocidadeDaVolta < pista.RecordEmSegundos)
      {
        pista.RecordEmSegundos = velocidadeDaVolta;

        pista.salvar();
      }
    }
  }
}
