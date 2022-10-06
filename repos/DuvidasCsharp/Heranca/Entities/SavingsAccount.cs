using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities
{
  class SavingsAccount : Account
  {
    public double InterestRate { get; set; }

    public SavingsAccount() { }

    public SavingsAccount(double interestRate,int number,string holder,double balance):base(number,holder,balance)
    {
      InterestRate = interestRate;
    }

    public void updateBalance()
    {
      Balance += Balance * InterestRate;
    }


  }
}
