using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace PengaduanMasyarakat.Layanan
{
    [ConnectionKey("Default"), Module("Layanan"), TableName("tanggapan")]
    [DisplayName("Tanggapan"), InstanceName("Tanggapan")]
    [ReadPermission("Tanggapan:Read")]
    [ModifyPermission("Tanggapan:Modify")]
    public sealed class TanggapanRow : Row<TanggapanRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Column("id"), Identity, IdProperty]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Id Pengaduan"), Column("id_pengaduan"), ForeignKey("pengaduan", "id"), LeftJoin("jIdPengaduan"), TextualField("IdPengaduanLaporan"), LookupEditor(typeof(PengaduanRow))]
        public int? IdPengaduan
        {
            get => fields.IdPengaduan[this];
            set => fields.IdPengaduan[this] = value;
        }

        [DisplayName("Tgl"), Column("tgl")]
        public DateTime? Tgl
        {
            get => fields.Tgl[this];
            set => fields.Tgl[this] = value;
        }

        [DisplayName("Tanggapan"), Column("tanggapan"), QuickSearch, NameProperty]
        public string Tanggapan
        {
            get => fields.Tanggapan[this];
            set => fields.Tanggapan[this] = value;
        }

        [DisplayName("Id Petugas"), Column("id_petugas"), LookupEditor(typeof(Administration.UserRow))]
        public int? IdPetugas
        {
            get => fields.IdPetugas[this];
            set => fields.IdPetugas[this] = value;
        }

        [DisplayName("Id Pengaduan Tanggal"), Expression("jIdPengaduan.[tanggal]")]
        public DateTime? IdPengaduanTanggal
        {
            get => fields.IdPengaduanTanggal[this];
            set => fields.IdPengaduanTanggal[this] = value;
        }

        [DisplayName("Id Pengaduan User Id"), Expression("jIdPengaduan.[user_id]")]
        public int? IdPengaduanUserId
        {
            get => fields.IdPengaduanUserId[this];
            set => fields.IdPengaduanUserId[this] = value;
        }

        [DisplayName("Id Pengaduan Laporan"), Expression("jIdPengaduan.[laporan]")]
        public string IdPengaduanLaporan
        {
            get => fields.IdPengaduanLaporan[this];
            set => fields.IdPengaduanLaporan[this] = value;
        }

        [DisplayName("Id Pengaduan Gambar"), Expression("jIdPengaduan.[gambar]")]
        public string IdPengaduanGambar
        {
            get => fields.IdPengaduanGambar[this];
            set => fields.IdPengaduanGambar[this] = value;
        }

        [DisplayName("Id Pengaduan Status"), Expression("jIdPengaduan.[status]")]
        public int? IdPengaduanStatus
        {
            get => fields.IdPengaduanStatus[this];
            set => fields.IdPengaduanStatus[this] = value;
        }

        public TanggapanRow()
            : base()
        {
        }

        public TanggapanRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public Int32Field IdPengaduan;
            public DateTimeField Tgl;
            public StringField Tanggapan;
            public Int32Field IdPetugas;

            public DateTimeField IdPengaduanTanggal;
            public Int32Field IdPengaduanUserId;
            public StringField IdPengaduanLaporan;
            public StringField IdPengaduanGambar;
            public Int32Field IdPengaduanStatus;
        }
    }
}