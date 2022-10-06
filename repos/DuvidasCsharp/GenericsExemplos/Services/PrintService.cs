using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericsExemplos.Services
{
  class PrintService
  {
    public List<int> Valor { get; set; }

    public void AddValue(int valor)
    {
      Valor.Add(valor);
    }

    public int First()
    {
      return Valor.First();
    }

    public string Print()
    {
      return $"{Valor}";
    }
  }
}
