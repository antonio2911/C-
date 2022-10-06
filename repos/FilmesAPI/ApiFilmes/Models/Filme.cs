using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFilmes.Models
{
  public class Filme
  {

    public int Id { get; set; }
    [Required(ErrorMessage = "Esse campo e Obrigatorio.")]
    public string Titulo { get; set; }
    [Required (ErrorMessage = "Esse campo e Obrigatorio.")]
    public string Diretor { get; set; }
    [StringLength(30, ErrorMessage ="Esse campo não pode passar de 30 caracteres.")]
    public string Genero { get; set; }
    [Range(1,600, ErrorMessage = "A duração tem que ser no minimo 1 e no maximo 600 minutos.")]
    public int Duracao { get; set; }
  }
}
