using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
  class Calc
  {
    public static int Soma(params int[] numeros) // o params indica que os parametros pode receber um numero variaveis de valores
    {
      int soma = 0;
      for(int i = 0; i < numeros.Length; i++)
      {
        soma += numeros[i];
      }
      return soma;
    }
  }
}
