using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechMeet
{
  class Pista
  {
    public string NomeDaPista { get; set; }
    public int RecordEmSegundos { get; set; }

    public List<int> ListaDeRecords { get; set; }

    public Pista()
    {

    }
    public Pista(string pista)
    {
      NomeDaPista = pista;
    }
    public void salvar()
    {
      ListaDeRecords.Add(RecordEmSegundos);
    }
  }
}
