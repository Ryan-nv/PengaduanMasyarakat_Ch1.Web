using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace PengaduanMasyarakat.Layanan.Columns
{
    [ColumnsScript("Layanan.Tanggapan")]
    [BasedOnRow(typeof(TanggapanRow), CheckNames = true)]
    public class TanggapanColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        public string IdPengaduanLaporan { get; set; }
        public DateTime Tgl { get; set; }
        [EditLink]
        public string Tanggapan { get; set; }
        public int IdPetugas { get; set; }
    }
}