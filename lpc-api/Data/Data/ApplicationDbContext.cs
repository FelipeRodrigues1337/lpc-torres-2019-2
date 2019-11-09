using Microsoft.EntityFrameworkCore;

namespace Data.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Domain.Models.Conta> Conta { get; set; }
        public DbSet<Domain.Models.Imovel> imovel { get; set; }
    
        
    }
}