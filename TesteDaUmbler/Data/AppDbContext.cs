using Microsoft.EntityFrameworkCore;
using TesteDaUmbler.Models;

namespace TesteDaUmbler.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Cartao> Cartoes { get; set; } = null!;

        public DbSet<Transacao> Transacoes { get; set; } = null!;
    }
}
