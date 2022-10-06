using ApiFilmes.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFilmes.Controllers
{
  [ApiController]
  [Route("[Controller]")]
  public class FilmeController: ControllerBase
  {
    private static List<Filme> filmes = new List<Filme>();
    private static int id = 1;

    [HttpPost]
    public IActionResult AdicionarFilme([FromBody] Filme filme)
    {
      filme.Id = id++;
      filmes.Add(filme);
      Console.WriteLine(filme.Titulo);
      return CreatedAtAction(nameof(RetornaListaDeFilmes), new { id = filme.Id }, filme);
    }
    [HttpGet]
    public List<Filme> RetornaListaDeFilmes()
    {
      return filmes;
    }
    [HttpGet("{id}")]
    public IActionResult RetornaListaDeFilmesPorId(int id)
    {

      foreach (Filme quantidade in filmes)
      {
        if(quantidade.Id == id)
        {
          return Ok(quantidade);
        }

      }
      return NotFound();
    }
  }
}

/*

[HttpGet("{id}")]
public IActionResult RetornaFilmePorId(int id)
{
Filmes filme = filmes.FirstOrDefault(filme => filme.Id == id);
if(filme != null)
{
  return Ok(filme);
}
return NotFound();
}
}
 */

/*
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



[ApiController] // define a class como controlador
  [Route("[controller]")] //essa expressão chama a class filmeController pela url = /Filme chama pelo controllerBase
  public class FilmeController : ControllerBase
  {
    
    private static List<Filmes> filmes = new List<Filmes>();
    private static int id = 1;
    [HttpPost]
    public IActionResult AdicionaFilme([FromBody] Filmes filme)
    {
      filme.Id = id++;
      filmes.Add(filme);
      Console.WriteLine(filme.Titulo);
      // criar a informação de onde foi criado o location
      return CreatedAtAction(nameof(RetornaFilmePorId), new {id = filme.Id},filme);
    }
    [HttpGet]
    public IActionResult RetornarOsFilmes()
    {
      return Ok(filmes);
    }
 */