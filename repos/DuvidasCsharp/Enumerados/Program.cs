using Enumerados.Entities;
using Enumerados.Entities.Enums;
using System;

namespace Enumerados
{
  class Program
  {
   public static void Main(string[] args)
    {
      Order pedido = new Order() 
      {
        Id = 1080,
        Moment = DateTime.Now,
        Status = OrderStatus.PendingPayment
      };

      Console.WriteLine(pedido);

      //  converter enum para string
      string txt = OrderStatus.Delivered.ToString();
      Console.WriteLine(txt);
      // ou 
      OrderStatus os = Enum.Parse<OrderStatus> ("Delivered");
      Console.WriteLine(os);
    }
  }
}
