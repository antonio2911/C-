using Dapper.Models;
using Dapper.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dapper.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class UsuariosController : ControllerBase
  {
   private IUsuarioRepository _repository;
    public UsuariosController()
    {
      _repository = new UsuarioRepository();
    }
    
    [HttpGet]
    public IActionResult Get()
    {
      return Ok(_repository.Get());
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
      var usuario = _repository.Get(id);

      if (usuario == null)
      {
      return NotFound(); // Erro 404
      }

        return Ok(usuario);
    }

    [HttpPost]
    public IActionResult Post([FromBody] Usuario usuario) {
      _repository.Insert(usuario);
      return Ok(usuario);
    }

    [HttpPut]
    public IActionResult Update([FromBody] Usuario usuario)
    {
      _repository.Update(usuario);
      return Ok(usuario);
    }
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
      _repository.Delete(id);
      return Ok();
    }

  }
}
