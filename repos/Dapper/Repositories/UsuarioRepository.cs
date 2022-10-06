
using Dapper;
using Dapper.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Dapper.Repositories
{
  public class UsuarioRepository : IUsuarioRepository
  {

    private IDbConnection _conection;

    //string de conexão com o banco
    public UsuarioRepository()
    {
     _conection =  new SqlConnection(@"Data Source=BHN050102974;Initial Catalog=Dapper;Integrated Security=True");
    }



    public void Delete(int id)
    {
      _db.Remove(_db.Find(x => x.Id == id));
    }

    public List<Usuario> Get()
    {
      return _conection.Query<Usuario>;
    }

    public Usuario Get(int id)
    {
      return _db.FirstOrDefault(x => x.Id == id);
    }

    public void Insert(Usuario usuario)
    {
      var ultimoUsuario = _db.LastOrDefault();

      if(ultimoUsuario == null)
      {
        usuario.Id = 1;
      }
      else
      {
        usuario.Id = ultimoUsuario.Id;
        usuario.Id++;
      }
      _db.Add(usuario);
 
    }

    public void Update(Usuario usuario)
    {
      _db.Remove(_db.Find(x => x.Id == usuario.Id));
      _db.Add(usuario);
    }

    private static List<Usuario> _db = new List<Usuario>()
    {
      new Usuario(){Id = 1, Email = "Luana@teste.com.br", Nome = "Luana"},
      new Usuario(){Id = 2, Email = "Gusta01@teste.com.br", Nome = "Gustavo"},
      new Usuario(){Id = 3, Email = "Berenice@quemDisseBerenice@teste.com", Nome = "Berenice Marechal"},
      new Usuario(){Id = 4, Email = "Toninho@toninho.com.br", Nome = "Anthony"},
      new Usuario(){Id = 5, Email = "marFreitas@teste.com.br", Nome = "Marcela Dias Freitas"},
    };
  }
}
