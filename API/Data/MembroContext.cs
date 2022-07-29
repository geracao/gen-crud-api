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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var membro = modelBuilder.Entity<Membro>();
            membro.ToTable("tb_membro");
            membro.HasKey(x => x.Id);
            membro.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            membro.Property(x => x.Nome).HasColumnName("nome").IsRequired();
            membro.Property(x => x.Email).HasColumnName("email").IsRequired();
            membro.Property(x => x.Github).HasColumnName("github").IsRequired();
            membro.Property(x => x.Phone).HasColumnName("phone").IsRequired();
        }
    }
}