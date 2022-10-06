using Microsoft.EntityFrameworkCore;
using System;

namespace Lojas2
{
  public class LojaContext : DbContext
  {
    internal DbSet<Produto> Produtos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer("Password=Asus1228@12345678;Persist Security Info=True;User ID=sa;Initial Catalog=LojasDB;Data Source=BHN050102974");
    }
  }
}