﻿using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosDapper.Models
{
  [Table("Usuarios")]
  public class Usuario
  {
    [Key]
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Sexo { get; set; }
    public string RG { get; set; }
    public string CPF { get; set; }
    public string NomeMae { get; set; }
    public string SituacaoCadastro { get; set; }
    public DateTimeOffset DataCadastro { get; set; }

    //Para o Dapper não levar em conta esse parametro na hora de inserir na tabela usuario
    [Write(false)]
    public Contato Contato { get; set; }

    [Write(false)]
    public ICollection<EnderecoDeEntrega> EnderecosEntrega { get; set; }

    [Write(false)]
    public ICollection<Departamento> Departamentos { get; set; }
  }
}