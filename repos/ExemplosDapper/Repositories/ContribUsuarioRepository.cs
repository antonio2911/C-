using ExemplosDapper.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace ExemplosDapper.Repositories
{
  public class ContribUsuarioRepository : IUsuarioRepository
  {

    private IDbConnection _conection;

    //string de conexão com o banco
    public ContribUsuarioRepository()
    {
      // FUNÇAO DO using System.Data.SqlClient QUE CRIA UMA STRING DE CONEXÃO QUE A GENTE PEGA ABRINDO O BANCO NO VS E PEGA A STRING EM PROPRIEDADES
      // F4
      _conection = new SqlConnection(@"Data Source=BHN050102974;Initial Catalog=Dapper;Integrated Security=True");
    }
    public List<Usuario> Get()
    {
      return _conection.GetAll<Usuario>().ToList();
    }

    public Usuario Get(int id)
    {
      return _conection.Get<Usuario>(id);
    }

    public void Insert(Usuario usuario)
    {
      usuario.Id = Convert.ToInt32(_conection.Insert(usuario));
    }

    public void Update(Usuario usuario)
    {
      _conection.Update(usuario);
    }

    public void Delete(int id)
    {
      //para o Delete e nescessario passar o objeto inteiro
      _conection.Delete(Get(id));
    }
  }
}
