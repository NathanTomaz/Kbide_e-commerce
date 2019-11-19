using Microsoft.EntityFrameworkCore;
using Kbide_desenvolvimento.Models;

namespace Kbide_desenvolvimento.Database
{
    public class KbideContext : DbContext
    {
        /*
         * EF Core - ORM
         * ORM -> Bibliteca mapear Objetos para Banco de Dados Relacionais
         */
         
        public KbideContext(DbContextOptions<KbideContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}