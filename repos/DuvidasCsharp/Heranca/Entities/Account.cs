using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities
{
  class Account
  {
    public int Number { get; set; }
    public string Holder { get; set; }
    public double Balance { get; set; }

    public Account()
    {

    }

    public Account(int number, string holder, double balance)
    {
      Number = number;
      Holder = holder;
      Balance = balance;
    }

    public void Saque(double quantia)
    {
      Balance -= quantia;
    }

    public void Deposito(double quantia)
    {
      Balance += quantia;
    }

  }
}
