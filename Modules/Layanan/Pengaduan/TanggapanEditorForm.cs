using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace PengaduanMasyarakat.Layanan.Forms
{
    [FormScript("Layanan.TanggapanEditor")]
    [BasedOnRow(typeof(TanggapanRow), CheckNames = true)]
    public class TanggapanEditorForm
    {
        public string Tanggapan { get; set; }
        [HalfWidth]
        public DateTime Tgl { get; set; }
        [HalfWidth, Insertable(false), StringEditor]
        public string Petugas { get; set; }
    }
}