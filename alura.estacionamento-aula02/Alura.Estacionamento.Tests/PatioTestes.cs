using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Alura.Estacionamento.Tests
{
 public class PatioTestes
  {
    [Fact]
    public void ValidaFaturamento()
    {
      //Arrange
      var estacionamento = new Patio();
      var veiculo = new Veiculo()
      {
        Proprietario = "Andre Silva",
        Tipo = TipoVeiculo.Automovel,
        Cor = "Verde",
        Modelo = "Fusca",
        Placa = "HLO-9900"
      };

      estacionamento.RegistrarEntradaVeiculo(veiculo);
      estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);

      //ACT
      double faturamento = estacionamento.TotalFaturado();

      //Assert
      Assert.Equal(2, faturamento);

    }
    [Theory]
    [InlineData("Andre Silva", "ADS-9999","preto","Gol")]
    [InlineData("Antonio Gonçalves", "AWS-4444","prata","palio")]
    [InlineData("Junior Pardim", "JKC-8432","preto","HRV")]
    [InlineData("Tom Tornado", "GFD-9087","Vermelho","FerrariGTI")]
    
    public void ValidaFaturamentoComVariosVeiculos(string proprietario,string placa,string cor,string modelo)
    {
      //Arrange
      Patio estacionamento = new Patio();

      var veiculo = new Veiculo() 
      {
        Proprietario = proprietario,
        Placa = placa,
        Cor = cor,
        Modelo = modelo
      };
      estacionamento.RegistrarEntradaVeiculo(veiculo);
      estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);

      //ACT
      double faturamento = estacionamento.TotalFaturado();

      //Assert
      Assert.Equal(2, faturamento);
    }
  }
}
