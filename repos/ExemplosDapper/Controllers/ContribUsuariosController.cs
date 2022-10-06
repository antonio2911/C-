using ExemplosDapper.Models;
using ExemplosDapper.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ExemplosDapper.Controllers
{
  [Route("api/Contrib/Usuarios")]
  [ApiController]
  public class ContribUsuariosController : ControllerBase
  {
       private IUsuarioRepository _repository;
    public ContribUsuariosController()
    {
    _repository = new ContribUsuarioRepository();
    }
    // DENTRO DE UM CONTROLLER [VERBO] LEVA AO METODO A ROTA TIPO LOCALHOST: 4200 E A FUNÇAO GET,POST,EM FIM
    // EXEMPLO METODO PUBLIC LER OBJETO(){ RETURN -REPOSITORY.GET}
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
    public IActionResult Post([FromBody] Usuario usuario)
    {
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
