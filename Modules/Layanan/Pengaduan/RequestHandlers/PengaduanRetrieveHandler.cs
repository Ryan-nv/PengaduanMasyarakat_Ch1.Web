using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<PengaduanMasyarakat.Layanan.PengaduanRow>;
using MyRow = PengaduanMasyarakat.Layanan.PengaduanRow;

namespace PengaduanMasyarakat.Layanan
{
    public interface IPengaduanRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class PengaduanRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPengaduanRetrieveHandler
    {
        public PengaduanRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}