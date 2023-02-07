using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace PengaduanMasyarakat.Layanan.Columns
{
    [ColumnsScript("Layanan.Pengaduan")]
    [BasedOnRow(typeof(PengaduanRow), CheckNames = true)]
    public class PengaduanColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        public DateTime Tanggal { get; set; }
        public int UserId { get; set; }
        [EditLink]
        public string Laporan { get; set; }
        [InlineImageFormatter] 
        public string Gambar { get; set; }
        [StatusFormatter, Width(100)] 
        public StatusEnum Status { get; set; }
    }
}