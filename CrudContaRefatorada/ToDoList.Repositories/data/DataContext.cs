using Microsoft.EntityFrameworkCore;
using ToDoList.classes;

namespace ToDoList.data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }

        public DbSet<ContaLuz> ContasLuz { get; set; }
        public DbSet<Imoveis> ImovelDb { get; set; }
    }
}