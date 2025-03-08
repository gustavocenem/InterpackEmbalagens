using InterpackEmbalagens.Models;
using Microsoft.EntityFrameworkCore;

namespace InterpackEmbalagens.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Estoque> Estoques { get; set; } = null!;

        protected ApplicationDbContext()
        {
        }
    }
}
