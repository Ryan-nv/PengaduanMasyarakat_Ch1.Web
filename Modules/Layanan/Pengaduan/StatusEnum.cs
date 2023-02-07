using Serenity.ComponentModel;
using System.ComponentModel;

namespace PengaduanMasyarakat.Layanan
{
    [EnumKey("Layanan.StatusEnum")]
    public enum StatusEnum {
        [Description("Diproses")]
        Diproses = 1,
        [Description("Disetujui")]
        Disetujui = 2,
        [Description("Ditolak")]
        Ditolak = 3,
    }
}