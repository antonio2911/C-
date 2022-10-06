using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ContratoExemploInterfaces.Entities;

namespace ContratoExemploInterfaces.Services
{
  class ServicoDeAluguel
  {
    public double PrecoPorHora { get; private set; }
    public double PrecoPorDia { get; private set; }

    private ITaxaServico taxaServico;

    public ServicoDeAluguel(double precoPorHora, double precoPorDia, ITaxaServico taxaDoServico)
    {
      PrecoPorHora = precoPorHora;
      PrecoPorDia = precoPorDia;
      taxaServico = taxaDoServico;
    }

    public void ProcessarPagamento(AluguelDoVeiculo aluguelDoVeiculo)
    {
      TimeSpan duracao = aluguelDoVeiculo.DataFim.Subtract(aluguelDoVeiculo.DataInicio);
      double pagamentoBasico = 0.0;
      if (duracao.TotalHours <= 12){
        pagamentoBasico = PrecoPorHora * Math.Ceiling(duracao.TotalHours);
      }
      else
      {
        pagamentoBasico = PrecoPorDia * Math.Ceiling(duracao.TotalHours);
      }
      double taxa = taxaServico.Taxa(pagamentoBasico);

      aluguelDoVeiculo.Fatura = new Fatura(pagamentoBasico, taxa);
    }
  }
}
