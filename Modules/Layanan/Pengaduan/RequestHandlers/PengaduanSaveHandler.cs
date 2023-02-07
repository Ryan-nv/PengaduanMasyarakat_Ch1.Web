using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<PengaduanMasyarakat.Layanan.PengaduanRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = PengaduanMasyarakat.Layanan.PengaduanRow;

namespace PengaduanMasyarakat.Layanan
{
    public interface IPengaduanSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class PengaduanSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPengaduanSaveHandler
    {
        public PengaduanSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}