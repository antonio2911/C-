using FilmesAPI.Controllers.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Controllers
{
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
    }
  

