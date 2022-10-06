using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetHastCodeExemplo.Entities
{
  class Clients
  {
    public string Nome { get; set; }
    public string Email { get; set; }

    //sobrescrevendo metodos

    public override bool Equals(object obj)
    {
      if(!(obj is Clients))
      {
        return false;
      }
      Clients outrocliente = obj as Clients;
      return Email.Equals(outrocliente.Email);
    }

    public override int GetHashCode()
    {
      return Email.GetHashCode();
    }
  }
}
