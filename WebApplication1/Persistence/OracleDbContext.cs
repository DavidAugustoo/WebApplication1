using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Persistence
{
    public class OracleDbContext : DbContext
    {
        public DbSet<Alunos> Alunos{ get; set; }

        public OracleDbContext(DbContextOptions<OracleDbContext> options) : base (options) 
        {

        }
    }
}
