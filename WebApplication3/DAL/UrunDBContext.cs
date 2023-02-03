using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.DAL
{
    public class UrunDBContext : DbContext
    {
        public UrunDBContext()
        {
        }

        public UrunDBContext(DbContextOptions<UrunDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Urun> Uruns { get; set; } = null!;
        public virtual DbSet<Kategori> Kategoris { get; set; } = null!;
        public virtual DbSet<Tedarikci> Tedarikcis { get; set; } = null!;
    }
}
