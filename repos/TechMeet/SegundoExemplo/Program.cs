using System;

namespace SegundoExemplo
{
  class Program
  {
    static void Main(string[] args)
    {
      Pista pista = new Pista("Interlagos");
      int vel = int.Parse(Console.ReadLine());
      if(vel < pista.R) 
      {
      pista.R = vel;
      pista.sResultado();
      }
    }
  }
}
