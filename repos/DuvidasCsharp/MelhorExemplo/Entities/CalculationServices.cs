using System;
using System.Collections.Generic;

namespace MelhorExemplo.Entities
{
  class CalculationServices
  {
    public T Max<T>(List<T> valores) where T : IComparable
    {
      if(valores.Count == 0)
      {
        throw new ArgumentException("Valor incluir um valor na lista");
      }

      T maximo = valores[0];

      for(int i = 1; i < valores.Count; i++)
      {
        //if(valores[i] > maximo) Informa um erro que não e possivel comparar Dois tipos da mesma interface
        //{                        Por esse motivo vamos utilizar a interface IComparable (serve para comparar um tipo com outro)
        //  maximo = valores[i];
        //}
        if(valores[i].CompareTo(maximo) > 0)
        {
          maximo = valores[i];
        }

      }

      return maximo;
    }
  }
}
