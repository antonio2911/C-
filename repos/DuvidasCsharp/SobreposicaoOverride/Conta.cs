using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreposicaoOverride
{
  public class Conta
  {
    //variaveis
    public int Numero { get; set; }

    public string Titular { get; set; }
    public double Saldo { get; set; }

    //Contrutores
    public Conta()
    {

    }
    public Conta(int numero,string titular,double saldo)
    {
      Numero = numero;
      Titular = titular;
      Saldo = saldo;
    }

    //Metodos
    // o operador virtual indica que o metodo pode ser sobrescrito para quem herdar a class
    // e so utilizar o mesmo nome de metodo com o Ovirride = sobrescrever
    public virtual void Saque(double quantia) 
    {
      // na conta para usar no empresarial ao qualquer um que herda a conta 
      // a operação de saque tem uma taxa fixa de 5 reais
      Saldo -= quantia + 5;
    }

    public void Deposito(double quantia) 
    {
      Saldo += quantia;
    }
  }
}
