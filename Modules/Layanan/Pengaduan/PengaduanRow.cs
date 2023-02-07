using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace PengaduanMasyarakat.Layanan
{
    [RegisterPermissionKey("GeneratePdf")]
    [ConnectionKey("Default"), Module("Layanan"), TableName("pengaduan")]
    [DisplayName("Pengaduan"), InstanceName("Pengaduan")]
    [ReadPermission("Pengaduan:Read")]
    [InsertPermission("Pengaduan:Insert")]
    [UpdatePermission("Pengaduan:Update")]
    
    [LookupScript(Permission ="*")]
    public sealed class PengaduanRow : Row<PengaduanRow.RowFields>, IIdRow, INameRow
    {
        // TODO : IMPLEMENT IMAGE UPLOAD AND DISPLAY INLINE IMAGE
        [DisplayName("Id"), Column("id"), Identity, IdProperty]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Tanggal"), Column("tanggal")]
        public DateTime? Tanggal
        {
            get => fields.Tanggal[this];
            set => fields.Tanggal[this] = value;
        }
        [DisplayName("User Id"), Column("user_id"), LookupEditor(typeof(Administration.UserRow))]
        public int? UserId
        {
            get => fields.UserId[this];
            set => fields.UserId[this] = value;
        }

        [DisplayName("Laporan"), Column("laporan"), QuickSearch, NameProperty]
        public string Laporan
        {
            get => fields.Laporan[this];
            set => fields.Laporan[this] = value;
        }

        [DisplayName("Gambar"), Column("gambar"), ImageUploadEditor] 
        public string Gambar
        {
            get => fields.Gambar[this];
            set => fields.Gambar[this] = value;
        }

        [DisplayName("Status"), Column("status"), RequiredPermission("Pengaduan:SetStatus")]
        public StatusEnum Status
        {
            get => (StatusEnum)fields.Status[this];
            set => fields.Status[this] = (int)value;
        }

        public PengaduanRow()
            : base()
        {
        }

        public PengaduanRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public DateTimeField Tanggal;
            public Int32Field UserId;
            public StringField Laporan;
            public StringField Gambar;
            public Int32Field Status;
        }
    }
}