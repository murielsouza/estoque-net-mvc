using Loja.Models;
using Microsoft.EntityFrameworkCore;

namespace Loja.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Produto> Produtos { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Produto>().Property(p => p.Nome).HasMaxLength(150).IsRequired();
        }
    }
}