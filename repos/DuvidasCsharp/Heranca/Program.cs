using Heranca.Entities;
using System;

namespace Heranca
{
  class Program
  {
    static void Main(string[] args)
    {

      //upcasting
      // na henraça as class tem o comportamento de e um ou seja a classe Account e herdada tanto para o business account
      // tanto para savingsaccount então Account e um bussines
      Account acc = new Account(1001,"Alex",0);

      BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0, 500);
      Account accdois = bacc;
      Account um = new BusinessAccount(7002, "João", 0, 500);
      Account dois = new SavingsAccount(12.0, 3, "Maria Joaquina", 0);
      //downCasting

      BusinessAccount acc4 = (BusinessAccount)accdois;
      acc4.Loan(100.00);
    }
  }
}
