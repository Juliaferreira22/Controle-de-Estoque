using Microsoft.EntityFrameworkCore; 


namespace Api.Models
{

    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Estoque> Estoques { get; set; }
        public DbSet<Produto> Produtos { get; set; }

    }

}