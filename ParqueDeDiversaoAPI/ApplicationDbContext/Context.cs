using Microsoft.EntityFrameworkCore;
using ParqueDeDiversaoAPI.Entities;

namespace ParqueDeDiversaoAPI.ApplicationDbContext;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options)
    {   }

    DbSet<Setor> Setores { get; set; }
    DbSet<Atracao> Atracoes { get; set; }
    DbSet<Barraquinha> Barraquinhas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<Atracao>()
            .HasOne(e => e.setor)
            .WithMany(e => e.Atracoes)
    }

}
