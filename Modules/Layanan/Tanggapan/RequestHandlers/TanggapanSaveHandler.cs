using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<PengaduanMasyarakat.Layanan.TanggapanRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = PengaduanMasyarakat.Layanan.TanggapanRow;

namespace PengaduanMasyarakat.Layanan
{
    public interface ITanggapanSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class TanggapanSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITanggapanSaveHandler
    {
        public TanggapanSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}