using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Controllers.Models
{
  public class Filmes
  {
    public int Id { get; set; }
    [Required (ErrorMessage = "O campo texto e obrigatorio")]
    public string Titulo { get; set; }
    [Required (ErrorMessage = "O campo Diretor e obrigatorio")]
    public string Diretor { get; set; }
    [StringLength(30, ErrorMessage = "O genero não pode passar de 30 caracteres!")]
    public string Genero { get; set; }
    [Range(1,600, ErrorMessage = "A duração deve ser de no minimo 1 e o maximo 600 minuto")]
    public int Duracao { get; set; }

  }
}
