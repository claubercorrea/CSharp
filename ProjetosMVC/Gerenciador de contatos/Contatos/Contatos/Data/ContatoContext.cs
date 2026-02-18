using Contatos.Models;
using Microsoft.EntityFrameworkCore;

namespace Contatos.Data
{
    public class ContatoContext:DbContext
    {
        public ContatoContext(DbContextOptions<ContatoContext> options ) :base(options) { }
        public DbSet<Contato> MeusContatos { get; set; }
    }
}
