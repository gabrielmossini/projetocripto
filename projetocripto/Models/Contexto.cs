using Microsoft.EntityFrameworkCore;
using projetocripto.Models;

namespace projetocripto.Models
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) :
            base(options)
        { }

        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Moeda> moedas { get; set; }
        public DbSet<Conta> contas { get; set; }
        public DbSet<Transasao> transasoes{ get; set; }
        public DbSet<projetocripto.Models.Impressora> Impressora { get; set; }
    }
}
