using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoExemplo
{
 public class Pista
  {
    public string NomeDaPista { get; set; }
    public int R { get; set; }

    public List<int> ListaDeRecords { get; set; }

    public Pista()
    {

    }
    public Pista(string pista)
    {
      NomeDaPista = pista;
    }
    public void sResultado()
    {
      ListaDeRecords.Add(R);
    }
  }
}
