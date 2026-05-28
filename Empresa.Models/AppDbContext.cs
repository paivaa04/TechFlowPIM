using Microsoft.EntityFrameworkCore;
using Empresa.Models;

namespace Empresa.Db
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() { }

        public DbSet<Login> Usuarios { get; set; }
        public DbSet<Chamado> Chamados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TechFlow;Integrated Security=True;Pooling=False");
            }
        }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Login>().ToTable("Usuarios");

       
            modelBuilder.Entity<Chamado>().ToTable("Chamados");

            base.OnModelCreating(modelBuilder);
        }
    }
}