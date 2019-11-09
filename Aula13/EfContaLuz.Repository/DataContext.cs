using Microsoft.EntityFrameworkCore;

namespace EfContaLuz.Models
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        :base(options)
        {

        }
        public DbSet<Conta> account { get; set; }
        public DbSet<Imovel> immobile { get; set; }
    }
}