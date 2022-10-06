using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreposicaoOverride
{
  //class : Herança
  class ContaEmpresarial : Conta
  {
    public double LimiteDeEmprestimo { get; set; }

    public ContaEmpresarial()
    {

    }
    // operador base para trazer os parametros do construtor da conta
    public ContaEmpresarial(double limiteDeEmprestimo,int numero,string titular,double saldo): base(numero,titular,saldo)
    {
      LimiteDeEmprestimo = limiteDeEmprestimo;
    }

    public void Emprestimo(double quantia)
    {
      if(quantia <= LimiteDeEmprestimo)
      {
        Saldo += quantia;
      }
    }

    public override void Saque(double quantia)
    {
      //ao inves de sobrescrever mudando toda a logica do saque
      // vou utilizar o operador base para aproveitar o que foi declarado em base e acrescentando parametros
      base.Saque(quantia); // conforme a regra da superClass
      Saldo -= 2;

      //descontou os 5 mais os dois
    }
  }
}
