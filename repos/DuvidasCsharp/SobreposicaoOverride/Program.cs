using System;
using System.Collections.Generic;
using System.Globalization;

namespace SobreposicaoOverride
{
  class Program
  {
    static void Main(string[] args)
    {
      Conta contaComun = new Conta(1000, "João", 500.00);
      double soma = 0.0;
      
      //Upcasting
      //com upcasting eu consigo estanciar a taxa de juros que tem na contaPoupanca porem não consigo 
      // acessar os metodos e propriedade que não existe em conta
      Conta contaPoupanca = new ContaPoupanca(0.01, 1001, "Pardim", 500.00);

      contaComun.Saque(10);
      contaPoupanca.Saque(10);

      Console.WriteLine($"conta Comun {contaComun.Saldo}");
      Console.WriteLine($"conta poupança {contaPoupanca.Saldo}");

      // exemplo de generalização de lista
      List<Conta> lista = new List<Conta>();
      lista.Add(new ContaPoupanca(0.1, 1001, "Toninho", 520.00));
      lista.Add(new ContaEmpresarial(1000,2002,"Amanda",12300.00));


      lista.ForEach(conta => 
      {
        soma += conta.Saldo;
        Console.WriteLine(conta.Titular);
        Console.WriteLine(conta.Saldo.ToString("F2", CultureInfo.InvariantCulture));
      });
      Console.WriteLine($"valor do saldo das contas somadas ({soma.ToString("F2")})");
    }
  }
}
