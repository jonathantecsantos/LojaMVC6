using LojaMVC6.Models;
using Microsoft.EntityFrameworkCore;

namespace LojaMVC6.Context;

public class AppDbContext : DbContext
{
   
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=ProjetoLanchesDB;Database=master;Trusted_Connection=True;");
    }

    public DbSet<Lanche> Lanches { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
}

