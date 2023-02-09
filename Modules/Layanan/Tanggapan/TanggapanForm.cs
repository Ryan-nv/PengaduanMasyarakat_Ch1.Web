using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace PengaduanMasyarakat.Layanan.Forms
{
    [FormScript("Layanan.Tanggapan")]
    [BasedOnRow(typeof(TanggapanRow), CheckNames = true)]
    public class TanggapanForm
    {
        public int IdPengaduan { get; set; }
        public DateTime Tgl { get; set; }
        public string Tanggapan { get; set; }
        public int IdPetugas { get; set; }
    }
}