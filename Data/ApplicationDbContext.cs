using Microsoft.EntityFrameworkCore;
using voltandoClasseStartup.Models;

namespace voltandoClasseStartup.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
            
        }

        public DbSet<EmprestimosModel> Emprestimos {get; set;}
        
    }
}