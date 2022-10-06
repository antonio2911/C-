using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreposicaoOverride
{
  //O operador sealed serve par selar a class ou seja a class ContaPoupanca não pode ser herdada
  sealed class ContaPoupanca: Conta
  {
    public double TaxaDeJuros { get; set; }

    public ContaPoupanca()
    {

    }

    public ContaPoupanca(double taxaDeJuros,int numero, string titular, double saldo) : base(numero, titular, saldo)
    {
      TaxaDeJuros = taxaDeJuros;
    }

    public void AtualizarSaldo()
    {
      Saldo += Saldo * TaxaDeJuros;
    }
   
    //O metodo saque sobrescreveu o saque da classe conta porem junto com o operador sealed
    // quem hedar a contaPoupança não pode mais sobrescrever esse metodo.
    public sealed override void Saque(double quantia)
    {
      Saldo -= quantia;
    }
  }
}
