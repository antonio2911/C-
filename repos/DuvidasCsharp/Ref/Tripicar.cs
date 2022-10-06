using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref
{
  class Tripicar
  {
    public static void Tripica(ref int x) // faz referencia a propria variavel que foi passada como parametro
    {
      x = x * 3;
    }

    public static void TripicaComRetorno(ref int x, out int resultado) // nesse cenario o ref faz referencia ao parametro recebido e o out e uma variavel de saida
    {
      resultado = x * 3;
    }
  }
}
