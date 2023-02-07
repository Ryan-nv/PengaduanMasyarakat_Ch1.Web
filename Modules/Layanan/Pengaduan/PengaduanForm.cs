using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace PengaduanMasyarakat.Layanan.Forms
{
    [FormScript("Layanan.Pengaduan")]
    [BasedOnRow(typeof(PengaduanRow), CheckNames = true)]
    public class PengaduanForm
    {
        public DateTime Tanggal { get; set; }
        public int UserId { get; set; }
        public string Laporan { get; set; }
        public string Gambar { get; set; }
        public StatusEnum Status { get; set; }
    }
}