using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<PengaduanMasyarakat.Layanan.TanggapanRow>;
using MyRow = PengaduanMasyarakat.Layanan.TanggapanRow;

namespace PengaduanMasyarakat.Layanan
{
    public interface ITanggapanRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class TanggapanRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITanggapanRetrieveHandler
    {
        public TanggapanRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}