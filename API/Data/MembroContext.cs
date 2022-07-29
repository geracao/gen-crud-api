using Microsoft.EntityFrameworkCore;
using API.Model;

namespace API.Data
{
    public class MembroContext : DbContext
    {
        public MembroContext(DbContextOptions<MembroContext> options) : base(options)
        {
        }

        public DbSet<Membro> Membros { get; set; }
    }
}