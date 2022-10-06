﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosDapper.Models
{
  public class Departamento
  {
    public int Id { get; set; }
    public string Nome { get; set; }
    public ICollection<Usuario> Usuario { get; set; }
  }
}
