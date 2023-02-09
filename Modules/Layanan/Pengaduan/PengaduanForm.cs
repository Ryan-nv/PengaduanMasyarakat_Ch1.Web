using Serenity.ComponentModel;
using Serenity.Web;
using System;
using System.Collections.Generic;

namespace PengaduanMasyarakat.Layanan.Forms
{
    [FormScript("Layanan.Pengaduan")]
    [BasedOnRow(typeof(PengaduanRow), CheckNames = false)]
    public class PengaduanForm
    {
        public string Laporan { get; set; }
        [HalfWidth]
        public DateTime Tanggal { get; set; }
        [HalfWidth, StringEditor]
        public string Username { get; set; }
        public string Gambar { get; set; }
        public StatusEnum Status { get; set; }
        [TanggapanEditor]
        public List<TanggapanRow> Tanggapan { get; set; }
    }
}