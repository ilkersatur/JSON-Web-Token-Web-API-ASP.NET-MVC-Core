using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Urun
    {
        public int UrunId { get; set; }
        public string? UrunAdi { get; set; }
        public int KategoriId { get; set; }
        public decimal Fiyat { get; set; }

        public virtual Kategori Kategori { get; set; } = null!;
    }
}
