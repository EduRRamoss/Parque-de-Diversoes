using Microsoft.EntityFrameworkCore;
using ParqueDeDiversaoAPI.Entities;

namespace ParqueDeDiversaoAPI.ApplicationDbContext;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options)
    {   }

    DbSet<Login> Logins { get; set; }
    DbSet<Setor> Setores { get; set; }
    DbSet<Atracao> Atracoes { get; set; }
    DbSet<Barraquinha> Barraquinhas { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Login>().HasKey(e => e.codigo);
        modelBuilder.Entity<Setor>().HasKey(e => e.codigo);
        modelBuilder.Entity<Atracao>().HasKey(e => e.codigo);
        modelBuilder.Entity<Barraquinha>().HasKey(e => e.codigo);

        modelBuilder.Entity<Setor>().Property(e => e.valorLiquidoArrecadado).HasPrecision(5,2);
        modelBuilder.Entity<Atracao>().Property(e => e.custoDeEntrada).HasPrecision(12,2);
        modelBuilder.Entity<Atracao>().Property(e => e.valorBrutoArrecadado).HasPrecision(8,2);
        modelBuilder.Entity<Atracao>().Property(e => e.valorCustoDeManutencao).HasPrecision(12,2);
        modelBuilder.Entity<Atracao>().Property(e => e.valorLiquidoArrecadado).HasPrecision(8,2);
        modelBuilder.Entity<Barraquinha>().Property(e => e.valorBrutoArrecadado).HasPrecision(8,2);
        modelBuilder.Entity<Barraquinha>().Property(e => e.valorCustoDeOperacao).HasPrecision(8,2);
        modelBuilder.Entity<Barraquinha>().Property(e => e.valorLiquidoArrecadado).HasPrecision(8,2);

        modelBuilder
            .Entity<Atracao>()
            .HasOne(e => e.setor)
            .WithMany(e => e.atracoes)
            .HasForeignKey(e => e.codigo)
            .IsRequired();
        
        modelBuilder
            .Entity<Barraquinha>()
            .HasOne(e => e.setor)
            .WithMany(e => e.barraquinhas)
            .HasForeignKey(e => e.codigo)
            .IsRequired();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
            optionsBuilder.UseSqlServer("DefaultConnection");

        base.OnConfiguring(optionsBuilder);
    }
}