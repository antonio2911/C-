using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dapper.Models
{
  public class Departamentos
  {
    public int Id { get; set; }
    public string Nome { get; set; }
    public ICollection<Usuario> Usuario { get; set; }
  }
}
