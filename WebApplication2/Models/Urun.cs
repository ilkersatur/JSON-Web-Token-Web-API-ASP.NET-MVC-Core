using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class Urun
    {
        public int UrunId { get; set; }
        public string? UrunAdi { get; set; }
        public int KategoriId { get; set; }
        public decimal Fiyat { get; set; }
    }
}
