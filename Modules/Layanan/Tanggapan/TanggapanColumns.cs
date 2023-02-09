using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace PengaduanMasyarakat.Layanan.Columns
{
    [ColumnsScript("Layanan.Tanggapan")]
    [BasedOnRow(typeof(TanggapanRow), CheckNames = true)]
    public class TanggapanColumns
    {
        public DateTime Tgl { get; set; }
        [EditLink]
        public string Tanggapan { get; set; }
        public string Petugas { get; set; }
    }
}