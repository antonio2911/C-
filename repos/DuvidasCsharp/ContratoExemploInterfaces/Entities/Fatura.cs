using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratoExemploInterfaces.Entities
{
  class Fatura
  {
    public double PagamentoBasico { get; set; }
    public double Taxa { get; set; }

    public Fatura(double pagamentoBasico, double taxa)
    {
      PagamentoBasico = pagamentoBasico;
      Taxa = taxa;
    }

    public double PagamentoTotal
    {
      get { return PagamentoBasico + Taxa; }
    }

    public override string ToString()
    {
      return $" Pagamento Basico: {PagamentoBasico.ToString("F2")}," +
        @$" Taxa: {Taxa.ToString("F2")},
            Pagamento Total {PagamentoTotal.ToString("F2", CultureInfo.InvariantCulture)}";
    }
  }
}
