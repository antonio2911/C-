using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesESctruck
{
 public class ClassExemplo
  {
    public string Produto;
    public double Valor;
    public int Quantidade;
    public double Total;

    public ClassExemplo()
    {

    }
    public ClassExemplo(string produto, double valor, int quantidade)
    {
      Produto = produto;
      Valor = valor;
      Quantidade = quantidade;
      Total = quantidade * valor;
    }



    //public override string ToString()
    //{
    //  return $"Produto = {Produto}, Valor = {Valor}, Quantidade = {Quantidade}, Total = {Total}";
    //}

    public string Imprimir()
    {
      return $"Produto = {Produto}, Valor = {Valor}, Quantidade = {Quantidade}, Total = {Total}";
    }
  }
}
