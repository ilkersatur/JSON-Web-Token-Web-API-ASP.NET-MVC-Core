namespace WebApplication3.Models
{
    public class Urun
    {
        public int UrunID { get; set; }
        public int UrunAdi { get; set; }
        public decimal Fiyat { get; set; }
        public DateTime Tarih { get; set; } 

        public Kategori? kategori { get; set; }
    }
}
