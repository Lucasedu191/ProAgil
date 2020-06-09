using Microsoft.EntityFrameworkCore;
using ProAgilv1.API.Model;

namespace ProAgilv1.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options): base (options){}

        public DbSet<Evento> Eventos { get; set; }
    }
}