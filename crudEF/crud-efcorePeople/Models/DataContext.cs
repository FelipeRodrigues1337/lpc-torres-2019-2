using Microsoft.EntityFrameworkCore;

namespace crud_efcorePeople.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options){

        }

        public  DbSet<Person> People { get; set; }

        
    }
}