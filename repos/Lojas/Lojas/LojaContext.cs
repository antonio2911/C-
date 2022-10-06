using Microsoft.EntityFrameworkCore;
using System;

namespace Lojas
{
  public class LojaContext : DbContext
  {
   public DbSet<Produto> produtos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer("Server=(localdb)\\SQL2019;Database=LojaDB;Trusted_Connection=true;");
    }
  }
}