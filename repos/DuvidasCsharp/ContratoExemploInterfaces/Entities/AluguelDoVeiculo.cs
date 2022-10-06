using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratoExemploInterfaces.Entities
{
  class AluguelDoVeiculo
  {
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public Veiculo Veiculo { get; set; }
    public Fatura Fatura { get; set; }

    public AluguelDoVeiculo(DateTime dataInicio, DateTime dataFim, Veiculo veiculo)
    {
      DataInicio = dataInicio;
      DataFim = dataFim;
      Veiculo = veiculo;
    }


  }
}
