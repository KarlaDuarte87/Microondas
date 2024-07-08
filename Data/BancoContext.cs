using Microondas_Digital.Models;
using Microsoft.EntityFrameworkCore;

namespace Microondas_Digital.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<Programas>  Programas { get; set; }

    }
}
