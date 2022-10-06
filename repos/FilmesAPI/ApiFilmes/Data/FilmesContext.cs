using ApiFilmes.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFilmes.Data
{
  public class FilmesContext: DbContext
  {
    public FilmesContext(DbContextOptions<FilmesContext> opt) : base(opt)
    {

    }
    public DbSet<Filme> filmes{ get; set; }
  }
}
