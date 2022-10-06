using ExemplosDapper.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace ExemplosDapper.Repositories
{
  public class UsuarioRepository : IUsuarioRepository
  {
    private IDbConnection _conection;

    //string de conexão com o banco
    public UsuarioRepository()
    {
      // FUNÇAO DO using System.Data.SqlClient QUE CRIA UMA STRING DE CONEXÃO QUE A GENTE PEGA ABRINDO O BANCO NO VS E PEGA A STRING EM PROPRIEDADES
      // F4
      _conection = new SqlConnection(@"Data Source=BHN050102974;Initial Catalog=Dapper;Integrated Security=True");
    }



    public void Delete(int id)
    {
      _conection.Execute("DELETE FROM USUARIOS WHERE Id = @Id", new { Id = id });
    }

    public List<Usuario> Get()
    {
      List<Usuario> usuarios = new List<Usuario>();
      string sql = "SELECT U.*, C.*, EE.*, D.* FROM Usuarios as U LEFT JOIN Contatos C ON C.UsuarioId = U.Id LEFT JOIN EnderecosEntrega EE ON EE.UsuarioId = U.Id LEFT JOIN UsuariosDepartamentos UD ON UD.UsuarioId = U.Id LEFT JOIN Departamentos D ON UD.DepartamentoId = D.Id";
      _conection.Query<Usuario, Contato, EnderecoDeEntrega,Departamento, Usuario>(sql,
        (usuario, contato, enderecoEntrega,departamento) =>
        {
          if (usuarios.SingleOrDefault(user => user.Id == usuario.Id) == null)
          {
            usuario.Departamentos = new List<Departamento>();
            usuario.EnderecosEntrega = new List<EnderecoDeEntrega>();
            usuario.Contato = contato;
            usuarios.Add(usuario);
          }
          else
          {
            usuario = usuarios.SingleOrDefault(user => user.Id == usuario.Id);
          }
          //verificação de endereço de entrega
          if(usuario.EnderecosEntrega.SingleOrDefault(endereco => endereco.Id == enderecoEntrega.Id) == null)
          {
            usuario.EnderecosEntrega.Add(enderecoEntrega);
          }

          //verificação do departamento
          if (usuario.Departamentos.SingleOrDefault(dep => dep.Id == departamento.Id) == null)
          {
            usuario.Departamentos.Add(departamento);
          }

          //return usuario e apenas para parar o erro de return do callback o importante e retornar uma lista de usuarios
          return usuario;
        });
      return usuarios;


      //___________________________PRIMEIRO METODO VISTO
      // QUERY E FUNÇÃO DO DAPPER QUE TRABALHA JUNTO COM SQLCLIENT 
      // ELA RECEBE CODIGO SQL E RETORNA O RESULTADO DESSA CONSULTA O TOLIST CONVERTE ESSE RESULTADO PARA UMA LISTA 
      // CADA LINHA SE TORNA UM OBJETO E AS COLUNAS OS PARAMETROS DESSE OBJETO
      // conection.query<Usuario> = sqlclient.dapper<Consulta no banco equivalente ao meu objeto Usuario>(query)
      // as mesmas colunas no banco tem que ser do meu modelo Usuario implementado

      // return _conection.Query<Usuario>("SELECT * FROM USUARIOS").ToList(); PRIMEIRO METODO DO CURSO
      //_______________________________________________________________________________________________________
    }

    public Usuario Get(int id)
    {
      List<Usuario> usuarios = new List<Usuario>();
      string sql = "SELECT U.*, C.*, EE.*, D.* FROM Usuarios as U LEFT JOIN Contatos C ON C.UsuarioId = U.Id LEFT JOIN EnderecosEntrega EE ON EE.UsuarioId = U.Id LEFT JOIN UsuariosDepartamentos UD ON UD.UsuarioId = U.Id LEFT JOIN Departamentos D ON UD.DepartamentoId = D.Id WHERE U.Id = @Id";
      _conection.Query<Usuario, Contato, EnderecoDeEntrega,Departamento, Usuario>(sql,
        (usuario, contato, enderecoEntrega,departamento) =>
        {
          if (usuarios.SingleOrDefault(user => user.Id == usuario.Id) == null)
          {
            usuario.Departamentos = new List<Departamento>();
            usuario.EnderecosEntrega = new List<EnderecoDeEntrega>();
            usuario.Contato = contato;
            usuarios.Add(usuario);
          }
          else
          {
            usuario = usuarios.SingleOrDefault(user => user.Id == usuario.Id);
          }

          //verificação de endereço de entrega
          if (usuario.EnderecosEntrega.SingleOrDefault(endereco => endereco.Id == enderecoEntrega.Id) == null)
          {
            usuario.EnderecosEntrega.Add(enderecoEntrega);
          }

          //verificação do departamento
          if (usuario.Departamentos.SingleOrDefault(dep => dep.Id == departamento.Id) == null)
          {
            usuario.Departamentos.Add(departamento);
          }
          //return usuario e apenas para parar o erro de return do callback o importante e retornar uma lista de usuarios
          return usuario;
        },new {Id = id });
      return usuarios.SingleOrDefault();

      //____________________PRIMEIRO METODO VISTO_______________________________________________________
      // O QUE E O QUERY SINGLE or default retorna o valor padrão caso a consulta não ter resultado.
      /*
       O método QuerySingle é um método de extensão que pode ser chamado de qualquer objeto do tipo IDbConnection. 
      Ele pode executar uma consulta e mapear o primeiro resultado e lançar uma exceção se não houver exatamente um elemento na sequência.
      Além disso, o mesmo tutorial fornece uma tabela simples para entender como eles funcionam:
      https://stackoverflow.com/questions/62300743/how-does-internally-querysingle-or-queryfirst-in-dapper-work

      query firt primeiro elemento
      query single unico elemento
       */
      //return _conection.Query<Usuario, Contato, Usuario>("SELECT * FROM Usuarios AS U LEFT JOIN Contatos C ON C.UsuarioId = U.Id WHERE U.Id = @Id",
      //  (usuario, contato) =>
      //  {
      //    usuario.Contato = contato;
      //    return usuario;
      //  }, new { Id = id }).SingleOrDefault();
      // Padrão do dapper passar o padramentro como um novo objeto anomino passando as propriedades ou passando o objeto inteiro no caso de um post
      // _CONECTION.QUERY RETORNA UM IENUMEREBLE O SINGLE OR DEFAUL PEGA O PRIMEIRO ELEMENTO DESSA LISTA
      // ______________________________________________________________________________________________________________________________________________

    }

    public void Insert(Usuario usuario)
    {
      _conection.Open(); // abrir A CONEXÃO
      var transaction = _conection.BeginTransaction();
      try
      {
        string sql = "INSERT INTO USUARIOS (Nome,Email,Sexo,RG,CPF,NomeMae,SituacaoCadastro,DataCadastro) VALUES (@Nome,@Email,@Sexo,@RG,@CPF,@NomeMae,@SituacaoCadastro,@DataCadastro); SELECT CAST(SCOPE_IDENTITY() AS INT);";
        usuario.Id = _conection.Query<int>(sql, usuario, transaction).Single();

        if (usuario.Contato != null)
        {
          usuario.Contato.UsuarioId = usuario.Id;
          string sqlContato = "INSERT INTO Contatos(UsuarioId,Telefone,Celular) VALUES (@UsuarioId,@Telefone,@Celular); SELECT CAST(SCOPE_IDENTITY() AS INT);";
          usuario.Contato.Id = _conection.Query<int>(sqlContato, usuario.Contato, transaction).Single();
        }

        if(usuario.EnderecosEntrega != null && usuario.EnderecosEntrega.Count > 0) 
        {
          foreach(var enderecoEntrega in usuario.EnderecosEntrega)
          {
            enderecoEntrega.UsuarioId = usuario.Id;
            string sqlEndereco = "INSERT INTO EnderecosEntrega (UsuarioId,NomeEndereco, CEP,Estado,Cidade,Bairro,Endereco,Numero,Complemento) VALUES (@UsuarioId,@NomeEndereco,@CEP,@Estado,@Cidade,@Bairro,@Endereco,@Numero,@Complemento); SELECT CAST(SCOPE_IDENTITY() AS INT);";

           enderecoEntrega.Id =  _conection.Query<int>(sqlEndereco, enderecoEntrega, transaction).Single();
          }
        }


        if (usuario.Departamentos != null && usuario.Departamentos.Count > 0)
        {
          foreach (var departamento in usuario.Departamentos)
          {
            string usuariosDepartamentos = "INSERT INTO UsuariosDepartamentos (UsuarioId,DepartamentoId) VALUES (@UsuarioId,@DepartamentoId)";

            _conection.Execute(usuariosDepartamentos, new {UsuarioId = usuario.Id, DepartamentoId = departamento.Id }, transaction);
          }
        }

        transaction.Commit();
      }
      catch (Exception)
      {
        try
        {
          transaction.Rollback();
        }
        catch (Exception)
        {
          //retornar para o usuario controller alguma mensagem
        }
      }
      finally
      {
        _conection.Close();
      }

      //  string sql = "INSERT INTO USUARIOS (Nome,Email,Sexo,RG,CPF,NomeMae,SituacaoCadastro,DataCadastro) VALUES (@Nome,@Email,@Sexo,@RG,@CPF,@NomeMae,@SituacaoCadastro,@DataCadastro)";
      ////   _conection.Query(sql, usuario);

      //// segundo metodo para retornar o cadastro do usuario e o id como resposta na requisição
      //string sql = "INSERT INTO USUARIOS (Nome,Email,Sexo,RG,CPF,NomeMae,SituacaoCadastro,DataCadastro) VALUES (@Nome,@Email,@Sexo,@RG,@CPF,@NomeMae,@SituacaoCadastro,@DataCadastro); SELECT CAST(SCOPE_INDENTITY() AS INT);";

      //// executa a query e espera um inteiro como resposta que no caso e o id e pega a primeira ocorrencia do banco com esse ip pelo metodo single()
      //usuario.Id = _conection.Query<int>(sql, usuario).Single();
    }

    public void Update(Usuario usuario)
    {
      _conection.Open();
      var transaction = _conection.BeginTransaction();
      try
      {
        string sql = "UPDATE Usuarios SET Nome = @Nome,Email = @Email,Sexo = @Sexo,RG = @RG,CPF = @CPF,NomeMae = @NomeMae,SituacaoCadastro = @SituacaoCadastro,DataCadastro = @DataCadastro WHERE Id = @Id";

        // _conection.Query<> = usa quando quer obter um retorno
        //_conection.Execute = quando quer executar um comando sem ter um retorno

        _conection.Execute(sql, usuario, transaction);

        if (usuario.Contato != null)
        {
          string sqlContato = "UPDATE Contatos SET UsuarioId = @UsuarioId, Celular = @Celular, Telefone = @Telefone WHERE Id = @Id";
          _conection.Execute(sqlContato, usuario.Contato, transaction);
        }

       string sqlDeletarEnderecos = "DELETE FROM EnderecosEntrega WHERE UsuarioId = @Id";
        _conection.Execute(sqlDeletarEnderecos, usuario, transaction);


        if (usuario.EnderecosEntrega != null && usuario.EnderecosEntrega.Count > 0)
        {
          foreach (var enderecoEntrega in usuario.EnderecosEntrega)
          {
            enderecoEntrega.UsuarioId = usuario.Id;
            string sqlEndereco = "INSERT INTO EnderecosEntrega (UsuarioId,NomeEndereco, CEP,Estado,Cidade,Bairro,Endereco,Numero,Complemento) VALUES (@UsuarioId,@NomeEndereco,@CEP,@Estado,@Cidade,@Bairro,@Endereco,@Numero,@Complemento); SELECT CAST(SCOPE_IDENTITY() AS INT);";

            enderecoEntrega.Id = _conection.Query<int>(sqlEndereco, enderecoEntrega, transaction).Single();
          }
        }

        string sqlDeletarDepartamentos = "DELETE FROM UsuariosDepartamentos WHERE UsuarioId = @Id";
        _conection.Execute(sqlDeletarDepartamentos, usuario, transaction);


        if (usuario.Departamentos != null && usuario.Departamentos.Count > 0)
        {
          foreach (var departamento in usuario.Departamentos)
          {
            string usuariosDepartamentos = "INSERT INTO UsuariosDepartamentos (UsuarioId,DepartamentoId) VALUES (@UsuarioId,@DepartamentoId)";

            _conection.Execute(usuariosDepartamentos, new { UsuarioId = usuario.Id, DepartamentoId = departamento.Id }, transaction);
          }
        }

        transaction.Commit();
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
      }
      finally
      {
        _conection.Close();
      }

    }


    //private static List<Usuario> _db = new List<Usuario>()
    //{
    //  new Usuario(){Id = 1, Email = "Luana@teste.com.br", Nome = "Luana"},
    //  new Usuario(){Id = 2, Email = "Gusta01@teste.com.br", Nome = "Gustavo"},
    //  new Usuario(){Id = 3, Email = "Berenice@quemDisseBerenice@teste.com", Nome = "Berenice Marechal"},
    //  new Usuario(){Id = 4, Email = "Toninho@toninho.com.br", Nome = "Anthony"},
    //  new Usuario(){Id = 5, Email = "marFreitas@teste.com.br", Nome = "Marcela Dias Freitas"},
    //};
  }
}
