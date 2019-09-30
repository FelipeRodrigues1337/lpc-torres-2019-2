using Microsoft.EntityFrameworkCore;

namespace contasLuz.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options){

        }

        public  DbSet<Conta> contaLuz { get; set; }
    }
}